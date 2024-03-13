using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    [Serializable]

    public class InvestmentAccount : PersonalAccount
    {
        private double investmentAmount;
        private double interestRate;

        public double InvestmentAmount { get => investmentAmount; set => investmentAmount = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }

        public InvestmentAccount(string firstName, string lastName, string address, string phoneNumber, string email, string id) 
            : base(firstName, lastName, address, phoneNumber, email, id)
        {
            InvestmentAmount = 0;
            InterestRate = 2.45;
        }
        public override bool Withdraw(double amount)
        {
            if (balance  >= amount)
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
            return (Balance + InvestmentAmount) * InterestRate;
        }
        public bool MakeInvestment(double Amount)
        {
            bool flag = true;

            flag = Withdraw(Amount);
            if (flag)
            {
                investmentAmount += Amount;
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
