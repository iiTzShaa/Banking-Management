using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Windows.Forms;



namespace Final_project
{
    public partial class accountsdata : Form
    {
        DataTable dataTable;



        public accountsdata()
        {
            InitializeComponent();
            
            dataTable = new DataTable();
            dataTable.Columns.Add("Account Id", typeof(string));
            dataTable.Columns.Add("Account Type", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Phone Number", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Balance", typeof(decimal));
        }

        public AccountManagerss PersonalAccountData { get; set; }
        public BusinessManager businessAccountData { get; set; }

        private void UpdateBalanceInDataTable(string accountId, string accountype, decimal newBalance)
        {
            DataRow[] rows = dataTable.Select("[Account ID] = '" + accountId + "' AND [Account Type] = '" + accountype + "'");
            if (rows.Length > 0)
            {
                rows[0]["Balance"] = newBalance;
            }

        }
        private void DisplayDataTable()
        {

            AccountsGridView.DataSource = dataTable;
        }

        public void SetAccountData(AccountManagerss personalAccountData, BusinessManager businessAccountData)
        {
            PersonalAccountData = personalAccountData;
            this.businessAccountData = businessAccountData;
        }


        private void AccessAccounts()
        {



        }
        private void button1_Click(object sender, EventArgs e)
        {

            string id = IDtext.Text;

            if (Personal.Checked)
            {
                if (PersonalAccountData.CheckingAccounts.ContainsKey(id))
                {
                    CheckingAccount foundAccount = PersonalAccountData.CheckingAccounts[id];

                    DataRow row = dataTable.NewRow();
                    row["Account Id"] = foundAccount.MyIDnumber;
                    row["Account Type"] = "Personal";
                    row["Name"] = foundAccount.myfirstname + " " + foundAccount.mylasttname;
                    row["Phone Number"] = foundAccount.myphone;
                    row["Email"] = foundAccount.myemail;
                    row["Balance"] = foundAccount.Balance;
                    dataTable.Rows.Add(row);
                    AccountsGridView.DataSource = dataTable;


                }
                else if (PersonalAccountData.InvestmentAccounts.ContainsKey(id))
                {
                    InvestmentAccount foundAccount = PersonalAccountData.InvestmentAccounts[id];


                    DataRow row = dataTable.NewRow();
                    row["Account Id"] = foundAccount.MyIDnumber;
                    row["Account Type"] = "Personal";
                    row["Name"] = foundAccount.myfirstname + " " + foundAccount.mylasttname;
                    row["Phone Number"] = foundAccount.myphone;
                    row["Email"] = foundAccount.myemail;
                    row["Balance"] = foundAccount.Balance;
                    AccountsGridView.DataSource = dataTable;


                }
                else
                {
                    MessageBox.Show("Account not found!");
                }
            }
            else if (Business.Checked)
            {
                if (businessAccountData.CheckingAccounts.ContainsKey(id))
                {
                    CheckingBusinessAccount foundAccount = businessAccountData.CheckingAccounts[id];

                    DataRow row = dataTable.NewRow();
                    row["Account Id"] = foundAccount.MyIDnumber;
                    row["Account Type"] = "Business";
                    row["Name"] = foundAccount.mycompanyName;
                    row["Phone Number"] = foundAccount.myphone;
                    row["Email"] = foundAccount.myemail;
                    row["Balance"] = foundAccount.Balance;
                    dataTable.Rows.Add(row);
                    AccountsGridView.DataSource = dataTable;


                }
                else if (businessAccountData.InvestmentAccounts.ContainsKey(id))
                {
                    InvestmentBusinessAccount foundAccount = businessAccountData.InvestmentAccounts[id];


                    DataRow row = dataTable.NewRow();
                    row["Account Id"] = foundAccount.MyIDnumber;
                    row["Account Type"] = "Business";
                    row["Name"] = foundAccount.mycompanyName;
                    row["Phone Number"] = foundAccount.myphone;
                    row["Email"] = foundAccount.myemail;
                    row["Balance"] = foundAccount.Balance;
                    dataTable.Rows.Add(row);
                    AccountsGridView.DataSource = dataTable;


                }
                else
                {
                    MessageBox.Show("Account not found!");
                }
            }
            else
            {
                MessageBox.Show("Please Select an account type");
            }

        }

        private void Firstnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Firstnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(char.IsLetter((char)e.KeyCode) || e.KeyCode == Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Invalid name- Only letters are allowed.");
            }

        }

        private void lastnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(char.IsLetter((char)e.KeyCode) || e.KeyCode == Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Invalid name- Only letters are allowed.");
            }

        }

        private void lastnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtext_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyCode) || e.KeyCode == Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Invalid ID - please enter digits only.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            if (withdraw.Text == "")
                MessageBox.Show("Please enter withdraw amount");
          
            else 
            {
                string accountId = IDtext.Text;
                string inputText = withdraw.Text;
                double amount;
                bool flag = true;


                if (double.TryParse(inputText, out amount))
                {
                    amount = double.Parse(withdraw.Text);
                    if (Personal.Checked)
                    {
                        if (PersonalAccountData.CheckingAccounts.ContainsKey(accountId))
                        {
                            CheckingAccount account = PersonalAccountData.CheckingAccounts[accountId];

                            // Call the Deposit method on the account
                            ; // Example deposit amount, modify as needed
                            flag = account.Withdraw(amount);

                            if (flag)
                            {
                                MessageBox.Show("Withdraw successful");
                                decimal newBalance = (decimal)account.Balance;
                                UpdateBalanceInDataTable(accountId, "Personal", newBalance);
                                DisplayDataTable();


                            }

                            else
                            {
                                MessageBox.Show("Withdraw failed, insufficient funds");

                            }


                        }
                        if (PersonalAccountData.InvestmentAccounts.ContainsKey(accountId))
                        {
                            InvestmentAccount account = PersonalAccountData.InvestmentAccounts[accountId];


                            flag = account.Withdraw(amount);

                            if (flag)
                            {
                                MessageBox.Show("Withdraw successful");
                                decimal newBalance = (decimal)account.Balance;
                                UpdateBalanceInDataTable(accountId, "Personal", newBalance);
                                DisplayDataTable();
                            }

                            else
                            {
                                MessageBox.Show("Withdraw failed, insufficient funds");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Account not found!");

                        }
                    }
                    else if (Business.Checked)
                    {
                        if (businessAccountData.CheckingAccounts.ContainsKey(accountId))
                        {
                            CheckingBusinessAccount account = businessAccountData.CheckingAccounts[accountId];


                            flag = account.Withdraw(amount);

                            if (flag)
                            {
                                MessageBox.Show("Withdraw successful");
                                decimal newBalance = (decimal)account.Balance;
                                UpdateBalanceInDataTable(accountId, "Business", newBalance);
                                DisplayDataTable();

                            }

                            else
                            {
                                MessageBox.Show("Withdraw failed, insufficient funds");

                            }
                        }
                        if (businessAccountData.InvestmentAccounts.ContainsKey(accountId))
                        {
                            InvestmentBusinessAccount account = businessAccountData.InvestmentAccounts[accountId];


                            flag = account.Withdraw(amount);

                            if (flag)
                            {
                                MessageBox.Show("Withdraw successful");
                                decimal newBalance = (decimal)account.Balance;
                                UpdateBalanceInDataTable(accountId, "Business", newBalance);
                                DisplayDataTable();

                            }

                            else
                            {
                                MessageBox.Show("Withdraw failed, insufficient funds");

                            }
                        }
                    }

                   
                    else
                    {
                        MessageBox.Show("Account not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Error: invalid inputs");
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            if (Deposittxt.Text == "")
                MessageBox.Show("Please enter Deposit amount");
            else
            {
                string accountId = IDtext.Text;
            
                string inputText = Deposittxt.Text;
                double amount;
                if (double.TryParse(inputText, out amount))
                {
                    amount = double.Parse(Deposittxt.Text);
                    if (Personal.Checked)

                    {
                        if (PersonalAccountData.CheckingAccounts.ContainsKey(accountId))
                        {
                            CheckingAccount account = PersonalAccountData.CheckingAccounts[accountId];
                            account.Deposit(amount);
                            MessageBox.Show("Deposit successful!");
                            decimal newBalance = (decimal)account.Balance;
                            UpdateBalanceInDataTable(accountId, "Personal", newBalance);


                        }
                        if (PersonalAccountData.InvestmentAccounts.ContainsKey(accountId))
                        {
                            InvestmentAccount account = PersonalAccountData.InvestmentAccounts[accountId];
                            account.Deposit(amount);

                            MessageBox.Show("Deposit successful!");
                            decimal newBalance = (decimal)account.Balance;
                            UpdateBalanceInDataTable(accountId, "Personal", newBalance);
                        }

                        else
                        {
                            MessageBox.Show("Account not found!");

                        }

                    }
                    else if (Business.Checked)
                    {
                        if (businessAccountData.CheckingAccounts.ContainsKey(accountId))
                        {
                            CheckingBusinessAccount account = businessAccountData.CheckingAccounts[accountId];
                            account.Deposit(amount);
                            MessageBox.Show("Deposit successful!");
                            decimal newBalance = (decimal)account.Balance;
                            UpdateBalanceInDataTable(accountId, "Business", newBalance);
                        }
                        if (businessAccountData.InvestmentAccounts.ContainsKey(accountId))
                        {
                            InvestmentBusinessAccount account = businessAccountData.InvestmentAccounts[accountId];
                            account.Deposit(amount);
                            MessageBox.Show("Deposit successful!");
                            decimal newBalance = (decimal)account.Balance;
                            UpdateBalanceInDataTable(accountId, "Business", newBalance);
                        }
                        else
                        {
                         
                            MessageBox.Show("Account not found!");
                        }
                    }

                }

                
                else
                {
                    MessageBox.Show("Error: invalid inputs");
                }
            }


        }

        private void Deposittxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void PopulateCheckingAccountsGridView()
        {


            
            foreach (KeyValuePair<string, CheckingAccount> kvp in PersonalAccountData.CheckingAccounts)
            {
                string accountId = kvp.Key;
                CheckingAccount account = kvp.Value;

                DataRow row = dataTable.NewRow();
                row["Account Id"] = accountId;
                row["Account Type"] = "Personal";
                row["Name"] = account.myfirstname + " " + account.mylasttname;
                row["Phone Number"] = account.myphone;
                row["Email"] = account.myemail;
                row["Balance"] = account.Balance;

                
                dataTable.Rows.Add(row);
            }
            foreach (KeyValuePair<string, CheckingBusinessAccount> kvp in businessAccountData.CheckingAccounts)
            {
                string accountId = kvp.Key;
                CheckingBusinessAccount account = kvp.Value;

                
                DataRow row = dataTable.NewRow();
                row["Account Id"] = accountId;
                row["Account Type"] = "Business";
                row["Name"] = account.mycompanyName;
                row["Phone Number"] = account.myphone;
                row["Email"] = account.myemail;
                row["Balance"] = account.Balance;

                
                dataTable.Rows.Add(row);
            }
            foreach (KeyValuePair<string, InvestmentAccount> kvp in PersonalAccountData.InvestmentAccounts)
            {
                string accountId = kvp.Key;
                InvestmentAccount account = kvp.Value;

                DataRow row = dataTable.NewRow();
                row["Account Id"] = accountId;
                row["Account Type"] = "Personal";
                row["Name"] = account.myfirstname + " " + account.mylasttname;
                row["Phone Number"] = account.myphone;
                row["Email"] = account.myemail;
                row["Balance"] = account.Balance;

                
                dataTable.Rows.Add(row);
            }
            foreach (KeyValuePair<string, InvestmentBusinessAccount> kvp in businessAccountData.InvestmentAccounts)
            {
                string accountId = kvp.Key;
                InvestmentBusinessAccount account = kvp.Value;

              
                DataRow row = dataTable.NewRow();
                row["Account Id"] = accountId;
                row["Account Type"] = "Business"; 
                row["Name"] = account.mycompanyName;
                row["Phone Number"] = account.myphone;
                row["Email"] = account.myemail;
                row["Balance"] = account.Balance;

                dataTable.Rows.Add(row);
            }

            
            AccountsGridView.DataSource = dataTable;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            PopulateCheckingAccountsGridView();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InvestmentAmount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Invest_Click(object sender, EventArgs e)
        {
            if (Investammount.Text == "")
                MessageBox.Show("please enter an amount");
            else
            {
                string accountId = IDtext.Text;
                double amount = double.Parse(Investammount.Text);
                bool flag = true;

                if (Personal.Checked)
                {
                    if (PersonalAccountData.InvestmentAccounts.ContainsKey(accountId))
                    {
                        InvestmentAccount account = PersonalAccountData.InvestmentAccounts[accountId];

                       flag=account.MakeInvestment(amount);
                        if (flag)
                        {
                            MessageBox.Show("Investment successful, the current amount invested is: " + account.InvestmentAmount);
                            decimal newBalance = (decimal)account.Balance;
                            UpdateBalanceInDataTable(accountId, "Personal", newBalance);
                            DisplayDataTable();

                        }

                        else
                        {
                            MessageBox.Show("Investment failed, insufficient funds");

                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Account not found!");

                    }

                }
                else if (Business.Checked)
                {
                    if (businessAccountData.InvestmentAccounts.ContainsKey(accountId))
                    {
                        InvestmentBusinessAccount account = businessAccountData.InvestmentAccounts[accountId];
                        flag = account.MakeInvestment(amount);
                        if (flag)
                        {
                            MessageBox.Show("Investment successful, the current amount invested is: " + account.InvestmentAmount);
                            decimal newBalance = (decimal)account.Balance;
                            UpdateBalanceInDataTable(accountId, "Business", newBalance);
                            DisplayDataTable();

                        }

                        else
                        {
                            MessageBox.Show("Investment failed, insufficient funds");

                        }
                       

                    }
                    else
                    {

                        MessageBox.Show("Account not found!");
                    }
                }
                else
                {
                    MessageBox.Show("please select an acoount type");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataTable.Clear();

        }

        private void Personal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Business_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (Months.Text == "")
            {
                MessageBox.Show("please enter a number of monthes");
            }
            else
            {
                string accountId = IDtext.Text;
                int months = int.Parse(Months.Text);
                double totalAmount;
                if (Business.Checked)
                {
                    if (businessAccountData.InvestmentAccounts.ContainsKey(accountId))
                    {
                        InvestmentBusinessAccount account = businessAccountData.InvestmentAccounts[accountId];
                        totalAmount = account.CalculateTotalAmountAfterYears(months);

                        MessageBox.Show("Total amount after " + months + " Years: " + totalAmount);
                    }
                }
                else if (Personal.Checked)
                {
                    if (PersonalAccountData.InvestmentAccounts.ContainsKey(accountId))
                    {
                        InvestmentAccount account = PersonalAccountData.InvestmentAccounts[accountId];

                        totalAmount = account.CalculateTotalAmountAfterYears(months);

                        MessageBox.Show("Total amount after " + months + " Years: " + totalAmount);

                    }

                }
                else
                {
                    MessageBox.Show("please select an acoount type");
                }

            }

            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {

                        formatter.Serialize(stream, businessAccountData);
                        formatter.Serialize(stream, PersonalAccountData);
                    }
                }
                catch(Exception ex)
                   {
                       // Handle any exceptions that occur during the database operation
                       // Display or log the error message
                       MessageBox.Show($"An error occurred: {ex.Message}");
                   }

            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                businessAccountData = (BusinessManager)binaryFormatter.Deserialize(stream);
                PersonalAccountData = (AccountManagerss)binaryFormatter.Deserialize(stream);
                PopulateCheckingAccountsGridView();

            }
        }

        private void Deposittxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyCode) || e.KeyCode == Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Invalid amount - please enter digits only.");
            }
        }

        private void withdraw_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyCode) || e.KeyCode == Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Invalid amount - please enter digits only.");
            }
        }

        private void withdraw_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyCode) || e.KeyCode == Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Invalid amount - please enter digits only.");
            }
        }
    }
}
        
    

  


