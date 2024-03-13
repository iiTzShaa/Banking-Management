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
    public partial class singupForm : Form
    {
        private Introscrean Introscrean;
        private AccountManagerss personalAccountData;
        private BusinessManager businessAccountData;
       

        public singupForm(AccountManagerss personalAccountData, BusinessManager businessAccountData, Introscrean Introscrean)
        {
            InitializeComponent();
            this.personalAccountData = personalAccountData; // Set the local variables
            this.businessAccountData = businessAccountData;
            this.Introscrean = Introscrean;
        }

        public AccountManagerss PersonalAccountData { get; set; }
        public BusinessManager BusinessAccountData { get; set; }
        public void SetAccountData(AccountManagerss personalAccountData, BusinessManager businessAccountData)
        {
            this.PersonalAccountData = personalAccountData;
            this.BusinessAccountData = businessAccountData;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (Business.Checked)
            {
                businesssignup businesssignup = new businesssignup(businessAccountData, Introscrean);
                businesssignup.Show(); // Use Show() instead of ShowDialog()
            }
            else if (Personal.Checked)
            {
                personalsignup personalsignup = new personalsignup(personalAccountData,Introscrean); // Pass the personalAccountData object
                personalsignup.SetAccountData(personalAccountData);
                personalsignup.Show(); // Use Show() instead of ShowDialog()
            }
            else
            {
                MessageBox.Show("Error: please select one of the two options");
            }

            this.Hide();


        }

        private void singupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
