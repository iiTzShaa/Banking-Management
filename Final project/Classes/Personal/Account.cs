using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    [Serializable]

    public abstract class Account
    {
        private int accountNumber;
        private string accountName;
        protected double balance;

        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public double Balance { get => balance; }

        public virtual void Deposit(double amount)
        {
            balance += amount;
        }

        public virtual bool Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        internal string GenerateAccountStatement()
        {
            throw new NotImplementedException();
        }

        public virtual double CalculateInterest()
        {
            return 0;
        }

        public virtual void GenerateMonthlyStatement()
        {
            // Generate statement and display it
        }
    }
}
