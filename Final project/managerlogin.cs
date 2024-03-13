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
    public partial class managerlogin : Form
    {
        private AccountManagerss personalAccountData;
        private BusinessManager businessAccountData;
        

        public managerlogin(AccountManagerss personalAccountData, BusinessManager businessAccountData)
        {
            InitializeComponent();
            this.personalAccountData = personalAccountData; // Set the local variables
            this.businessAccountData = businessAccountData;
        }

        string username1 = "sharon";
        string password1 = "316440601";

        string username2 = "yuval";
        string password2 = "318815966";

        public AccountManagerss PersonalAccountData { get; set; }
        public BusinessManager BusinessAccountData { get; set; }
        public void SetAccountData(AccountManagerss personalAccountData, BusinessManager businessAccountData)
        {
            this.PersonalAccountData = personalAccountData;
            this.BusinessAccountData = businessAccountData;
        }
        private void managerlogin_Load(object sender, EventArgs e)
        {

        }
        private bool IsValidLogin(string enteredUsername, string enteredPassword)
        {
            if ((enteredUsername == username1 && enteredPassword == password1) ||
                (enteredUsername == username2 && enteredPassword == password2))
            {
                // Valid username and password
                return true;
            }

            // Invalid username or password
            return false;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;

            // Validate the entered username and password
            if (IsValidLogin(enteredUsername, enteredPassword))
            {
                // Login successful
                MessageBox.Show("Login successful!");
                // Proceed with account management or any other actions
                managerform managerform = new managerform(personalAccountData, businessAccountData);
                managerform.SetAccountData(personalAccountData, businessAccountData);
                managerform.ShowDialog();
                this.Hide();

            }
            else
            {
                // Invalid username or password
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = true; // Show password
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false; // Mask password
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    
}
