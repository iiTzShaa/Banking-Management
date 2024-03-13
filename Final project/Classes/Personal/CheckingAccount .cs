using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    [Serializable]

    public class CheckingAccount : PersonalAccount
    {
        private double overdraftLimit;

        public double OverdraftLimit { get => overdraftLimit; set => overdraftLimit = value; }

        public CheckingAccount(string firstName, string lastName, string address, string phoneNumber, string email, string id)
         : base(firstName, lastName, address, phoneNumber, email, id)
        {
            this.overdraftLimit = 2000;
        }

        public override bool Withdraw(double amount)
        {
            if (balance + overdraftLimit >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
        public override void Deposit(double amount)
        {
            balance += amount;
        }
    }
}
