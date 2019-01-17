using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmKata.Model
{
    public class WithDraw : ITransaction
    {
        public IAccount Account { get ; set ; }
        public decimal Amount { get ; set ; }

        public void Execute()
        {
            Account.Debit(Amount);
        }
    }
}
