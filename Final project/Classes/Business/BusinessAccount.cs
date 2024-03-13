using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    [Serializable]

    public class BusinessAccount : Account
    {
        private string companyName;
        private string address;
        private string phoneNumber;
        private string email;
        private string id;

        public BusinessAccount(string companyName, string address, string phoneNumber, string email, string id)
        {

      
            this.companyName = companyName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.id = id;
            this.balance = 0;

        }
        public string MyIDnumber { get => id; set => id = value; }
        public string mycompanyName { get => companyName; }
        public string myphone { get => phoneNumber; }

        public string myaddress { get => address; }
        public string myemail { get => email; }
        public override double CalculateInterest()
        {
           
            return base.CalculateInterest() * 1.35;
        }
    }
}
