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
    public partial class businesssignup : Form
    {
        private BusinessManager businessAccountData;
        private Introscrean Introscrean;


        public BusinessManager PersonalAccountData { get; set; }
        public void SetAccountData(BusinessManager businessAccountData)
        {
            PersonalAccountData = businessAccountData;
            
        }
       
        public businesssignup(BusinessManager businessAccountData, Introscrean Introscrean)
        {
            InitializeComponent();
            this.Introscrean = Introscrean;
            this.businessAccountData = businessAccountData;
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Compnyname.Text == "" || Adresstext.Text == "" || Phonetxt.Text == "" || Emailtxt.Text == "" || IDtext.Text == "")
                MessageBox.Show("Fill the blanks");
            else if (Investment.Checked)
            {
                if (businessAccountData.InvestmentAccounts.ContainsKey(IDtext.Text))
                {
                    MessageBox.Show("This account for given ID already exist");
                }
                else
                {
                    InvestmentBusinessAccount Businessaccount = new InvestmentBusinessAccount(Compnyname.Text, Adresstext.Text, Phonetxt.Text, Emailtxt.Text, IDtext.Text, 0.0);
                    businessAccountData.InvestmentAccounts.Add(IDtext.Text, Businessaccount);
                    MessageBox.Show("the Investment account was created successfully");
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

             else if(Checking.Checked)
            {
                if (businessAccountData.CheckingAccounts.ContainsKey(IDtext.Text))
                {
                    MessageBox.Show("This account for given ID already exist");
                }
                else
                {
                    CheckingBusinessAccount account = new CheckingBusinessAccount(Compnyname.Text, Adresstext.Text, Phonetxt.Text, Emailtxt.Text, IDtext.Text);
                    businessAccountData.CheckingAccounts.Add(IDtext.Text, account);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Compnyname_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(char.IsLetter((char)e.KeyCode) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Invalid Compny name- Only letters are allowed.");
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
            String email = Emailtxt.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address!");
            }
        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
