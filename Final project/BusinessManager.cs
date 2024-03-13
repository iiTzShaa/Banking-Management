using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    [Serializable]
    public class BusinessManager
    {
        public SortedList<string, CheckingBusinessAccount> CheckingAccounts { get; set; } = new SortedList<string, CheckingBusinessAccount>();
        public SortedList<string, InvestmentBusinessAccount> InvestmentAccounts { get; set; } = new SortedList<string, InvestmentBusinessAccount>();
    }
}
