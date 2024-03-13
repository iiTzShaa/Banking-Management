using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    [Serializable]

    public class AccountManagerss
    {
        public SortedList<string, CheckingAccount> CheckingAccounts { get; set; } = new SortedList<string, CheckingAccount>();
         public SortedList<string, InvestmentAccount> InvestmentAccounts { get; set; } = new SortedList<string, InvestmentAccount>();
      
    }
}
