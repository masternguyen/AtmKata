using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmKata.Model
{
    public class Account : IAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get ; set ; }

        public void Debit(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
