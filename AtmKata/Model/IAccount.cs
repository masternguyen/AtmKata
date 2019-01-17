using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmKata.Model
{
    public interface IAccount
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Balance { get; set; }
        void Debit(decimal amount);
    }
}
