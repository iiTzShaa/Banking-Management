using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    [Serializable]

    public class InvestmentBusinessAccount : BusinessAccount
    {
        private double interestRate;
        private double investmentAmount;

        public double InvestmentAmount { get => investmentAmount; set => investmentAmount = value; }

        public double InterestRate { get => interestRate; set => interestRate = value; }

        public InvestmentBusinessAccount(string companyName, string address, string phoneNumber, string email, string id, double interestRate)
            : base(companyName, address, phoneNumber, email, id)
        {
            this.interestRate = 1;
            this.InvestmentAmount = 4.25;

        }
        public override bool Withdraw(double amount)
        {
            if (balance >= amount)
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

        public override double CalculateInterest()
        {
            return balance * (interestRate / 100);

        }
        public bool MakeInvestment(double Amount)
        {
            bool flag = true;
            
            flag = Withdraw(Amount);
             if (flag)
            {
                investmentAmount+= Amount;
                return flag;
            }
             else
            {
                return flag;
            }

        }
        public double CalculateTotalAmountAfterYears(int years)
        {
            double totalAmount = investmentAmount;
            double yearlyInterestRate = InterestRate;

            for (int i = 0; i < years; i++)
            {
                totalAmount += totalAmount * (yearlyInterestRate / 100);
            }

            return totalAmount;
        }

    }

}
