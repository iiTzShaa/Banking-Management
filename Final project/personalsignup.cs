using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Final_project
{
    public partial class personalsignup : Form
    {
        private AccountManagerss personalAccountData;
        private Introscrean Introscrean;

     


        public personalsignup(AccountManagerss personalAccountData, Introscrean Introscrean)
        {
            InitializeComponent();
            this.Introscrean = Introscrean;
            this.personalAccountData = personalAccountData;

        }
        public AccountManagerss PersonalAccountData { get; set; }
        public void SetAccountData(AccountManagerss personalAccountData)
        {
            PersonalAccountData = personalAccountData;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void lastnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lastnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(char.IsLetter((char)e.KeyCode) || e.KeyCode == Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Invalid name- Only letters are allowed.");
            }
        }

        private void Phonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phonetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyCode) || e.KeyCode == Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Invalid Phone number - please enter digits only.");
            }
        }

        private void Emailtxt_Leave(object sender, EventArgs e)
        {
            string email = Emailtxt.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address!");
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Firstnametxt.Text == "" || lastnametxt.Text == "" || Adresstext.Text == "" || Phonetxt.Text == "" || Emailtxt.Text == "" || IDtext.Text == "")
                MessageBox.Show("Fill the blanks");
            

            else if (Checking.Checked)
            {
                if (PersonalAccountData.CheckingAccounts.ContainsKey(IDtext.Text))
                {
                    MessageBox.Show("This account for given ID already exist");
                }
                else
                {
                    CheckingAccount account = new CheckingAccount(Firstnametxt.Text, lastnametxt.Text, Adresstext.Text, Phonetxt.Text, Emailtxt.Text, IDtext.Text);
                    personalAccountData.CheckingAccounts.Add(IDtext.Text, account);
                    MessageBox.Show("the Checking account was created successfully");
                    try
                    {
                        this.Hide();
                        Introscrean.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
        

                }
                
            }


            else if (Investment.Checked)
            {
                if (PersonalAccountData.InvestmentAccounts.ContainsKey(IDtext.Text))
                {
                    MessageBox.Show("This account for given ID already exist");
                }
                else
                {
                    InvestmentAccount account2 = new InvestmentAccount(Firstnametxt.Text, lastnametxt.Text, Adresstext.Text, Phonetxt.Text, Emailtxt.Text, IDtext.Text);
                    personalAccountData.InvestmentAccounts.Add(IDtext.Text, account2);

                    MessageBox.Show("the Checking account was created successfully");
                    try
                    {
                        this.Hide();
                        Introscrean.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

   

            }
        }



        private void Adresstext_TextChanged(object sender, EventArgs e)
        {

        }

        private void personalsignup_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IDtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcNAme_Click(object sender, EventArgs e)
        {

        }

    }
}

