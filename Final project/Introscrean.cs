using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Final_project
{
    public partial class Introscrean : Form
    {
        
        private AccountManagerss personalAccountData;
        private BusinessManager businessAccountData;

        public Introscrean()
        {
            InitializeComponent();
            
            personalAccountData = new AccountManagerss();
            businessAccountData = new BusinessManager();
            CheckingAccount checkingAccount = new CheckingAccount("John", "Doe", "123 Main St", "555-1234", "john@example.com", "12345");

            personalAccountData.CheckingAccounts.Add(checkingAccount.MyIDnumber, checkingAccount);

            // Create the CheckingBusinessAccount object with fixed values
            CheckingBusinessAccount account = new CheckingBusinessAccount("Example Company", "123 Main Street", "123-456-7890", "example@example.com", "12345");

            // Add the account to the businessAccountData list
            businessAccountData.CheckingAccounts.Add(account.MyIDnumber, account);


        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string name = textBox1.Text;
        //    MessageBox.Show("Hello your name is " + name);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            accountsdata accountsDataForm = new accountsdata();
            accountsDataForm.SetAccountData(personalAccountData,businessAccountData);
            accountsDataForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            singupForm singupForm = new singupForm(personalAccountData, businessAccountData,this);
            singupForm.SetAccountData(personalAccountData, businessAccountData);
            singupForm.ShowDialog();
            this.Hide();

        }

        private void Introscrean_Load(object sender, EventArgs e)
        {

        }

        private void Manageaccount_Click(object sender, EventArgs e)
        {
            managerlogin managerlogin = new managerlogin(personalAccountData, businessAccountData);
            managerlogin.SetAccountData(personalAccountData, businessAccountData);
            managerlogin.ShowDialog();
        }
    }
}
