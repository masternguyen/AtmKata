using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmKata.Model
{
    public interface ITransaction
    {
        IAccount Account { get; set; }
        decimal Amount { get; set; }
        void Execute();
    }
}
