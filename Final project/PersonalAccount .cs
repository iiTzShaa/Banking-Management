using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    [Serializable]

    public class PersonalAccount : Account
    {
        private string dateOfBirth;
        private string IDnumber;
        private string firstName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private string email;

        public PersonalAccount(string firstName, string lastName, string address, string phoneNumber, string email, string IDnumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.balance = 0;
            this.IDnumber = IDnumber;
        }
            

        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string MyIDnumber { get => IDnumber; set => IDnumber = value; }
        public string myfirstname { get => firstName;}
        public string mylasttname { get => lastName; }
        public string myaddress { get => address; }
        public string myemail { get => email; }
        public string myphone { get => phoneNumber; }


        public override double CalculateInterest()
        {

            return base.CalculateInterest() * 1.02;
        }
        public new string GenerateAccountStatement()
        {
            string statement = base.GenerateAccountStatement();
            statement += "Date of birth: " + DateOfBirth + "\n";
            statement += "Social security number: " + IDnumber + "\n";
            statement += "Current interest rate: " + CalculateInterest().ToString("C") + "\n";
            return statement;
        }
    }
}
