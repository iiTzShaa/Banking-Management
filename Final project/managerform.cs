using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class managerform : Form
    {

        private AccountManagerss personalAccountData;
        private BusinessManager businessAccountData;
        DataTable dataTable;


        public managerform(AccountManagerss personalAccountData, BusinessManager businessAccountData)
        {
            InitializeComponent();
            this.personalAccountData = personalAccountData; // Set the local variables
            this.businessAccountData = businessAccountData;
            dataTable = new DataTable();

            dataTable.Columns.Add("Account Id", typeof(string));
            dataTable.Columns.Add("Account Type", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Phone Number", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Balance", typeof(decimal));
        }
        private void RefreshAccountsGridView()
        {
            // Assuming you have a DataGridView named "dataGridView" to display the account information
            AccountsGridView.DataSource = null; // Clear the current data source
            AccountsGridView.DataSource = dataTable; // Set the data source again
            fillTable();
        }

        private void DeleteRowsFromDataTable(string accountId)
        {
            DataRow[] rowsToDelete = dataTable.Select("[Account ID] = '" + accountId + "'");
            foreach (DataRow row in rowsToDelete)
            {
                dataTable.Rows.Remove(row);
            }
        }
        private void DisplayDataTable()
        {

            AccountsGridView.DataSource = dataTable;
        }
        public AccountManagerss PersonalAccountData { get; set; }
        public BusinessManager BusinessAccountData { get; set; }
        public void SetAccountData(AccountManagerss personalAccountData, BusinessManager businessAccountData)
        {
            this.PersonalAccountData = personalAccountData;
            this.BusinessAccountData = businessAccountData;
        }

        private void fillTable()
        {
            // Populate the DataTable with checking account data
            foreach (KeyValuePair<string, CheckingAccount> kvp in PersonalAccountData.CheckingAccounts)
            {
                string accountId = kvp.Key;
                CheckingAccount account = kvp.Value;

                // Create a new DataRow with the account details
                DataRow row = dataTable.NewRow();
                row["Account Id"] = accountId;
                row["Account Type"] = "Personal";
                row["Name"] = account.myfirstname + " " + account.mylasttname;
                row["Phone Number"] = account.myphone;
                row["Email"] = account.myemail;
                row["Balance"] = account.Balance;

                // Add the DataRow to the DataTable
                dataTable.Rows.Add(row);
            }
            foreach (KeyValuePair<string, CheckingBusinessAccount> kvp in businessAccountData.CheckingAccounts)
            {
                string accountId = kvp.Key;
                CheckingBusinessAccount account = kvp.Value;

                // Create a new DataRow with the account details
                DataRow row = dataTable.NewRow();
                row["Account Id"] = accountId;
                row["Account Type"] = "Business"; // Set the "FirstName" value to empty for business accounts
                row["Name"] = account.mycompanyName;
                row["Phone Number"] = account.myphone;
                row["Email"] = account.myemail;
                row["Balance"] = account.Balance;

                // Add the DataRow to the DataTable
                dataTable.Rows.Add(row);
            }
            foreach (KeyValuePair<string, InvestmentAccount> kvp in PersonalAccountData.InvestmentAccounts)
            {
                string accountId = kvp.Key;
                InvestmentAccount account = kvp.Value;

                // Create a new DataRow with the account details
                DataRow row = dataTable.NewRow();
                row["Account Id"] = accountId;
                row["Account Type"] = "Personal";
                row["Name"] = account.myfirstname + " " + account.mylasttname;
                row["Phone Number"] = account.myphone;
                row["Email"] = account.myemail;
                row["Balance"] = account.Balance;

                // Add the DataRow to the DataTable
                dataTable.Rows.Add(row);
            }
            foreach (KeyValuePair<string, InvestmentBusinessAccount> kvp in businessAccountData.InvestmentAccounts)
            {
                string accountId = kvp.Key;
                InvestmentBusinessAccount account = kvp.Value;

                // Create a new DataRow with the account details
                DataRow row = dataTable.NewRow();
                row["Account Id"] = accountId;
                row["Account Type"] = "Business"; // Set the "FirstName" value to empty for business accounts
                row["Name"] = account.mycompanyName;
                row["Phone Number"] = account.myphone;
                row["Email"] = account.myemail;
                row["Balance"] = account.Balance;

                // Add the DataRow to the DataTable
                dataTable.Rows.Add(row);
            }

            // Assign the DataTable as the data source for your data-bound control
            AccountsGridView.DataSource = dataTable;
        }
        private void managerform_Load(object sender, EventArgs e)
        {

        }

        private void IDtext_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fillTable();
        }

        private void deleteaccount_Click(object sender, EventArgs e)
        {
            string id = IDtext.Text;

            if (Personal.Checked)
            {
                if (PersonalAccountData.CheckingAccounts.ContainsKey(id))
                {
                    CheckingAccount foundAccount = PersonalAccountData.CheckingAccounts[id];
                    PersonalAccountData.CheckingAccounts.Remove(id);
                    DeleteRowsFromDataTable(id);

                    // Refresh the DataGridView or perform any other necessary actions
                    RefreshAccountsGridView();
                }
                else if (PersonalAccountData.InvestmentAccounts.ContainsKey(id))
                {
                    InvestmentAccount foundAccount = PersonalAccountData.InvestmentAccounts[id];
                    PersonalAccountData.InvestmentAccounts.Remove(id);
                    DeleteRowsFromDataTable(id);
                    RefreshAccountsGridView();
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
                    businessAccountData.CheckingAccounts.Remove(id);
                    DeleteRowsFromDataTable(id);
                    RefreshAccountsGridView();
                }
                else if (businessAccountData.InvestmentAccounts.ContainsKey(id))
                {
                    InvestmentBusinessAccount foundAccount = businessAccountData.InvestmentAccounts[id];

                    businessAccountData.InvestmentAccounts.Remove(id);
                    DeleteRowsFromDataTable(id);
                    RefreshAccountsGridView();
                }

                else
                {
                    MessageBox.Show("Account not found!");
                }

            }

            else
            {
                MessageBox.Show("Please Select an account type!");
            }

        }

    }
}
