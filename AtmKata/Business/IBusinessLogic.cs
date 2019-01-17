using AtmKata.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmKata.Business
{
    public interface IBusinessLogic
    {
        ICashDispenser WithDraw(string name, decimal amount);
        IDab GetDab();
        decimal GetBalanceByName(string name); 
    }
}
