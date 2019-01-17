using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmKata.Model
{
    class Dab : IDab
    {
        private int[] _bills { get ; }
        public int[] NumberOfBills { get ; set ; }
        public Dab(int[] bills)
        {
            _bills = bills;
        }

        public void WithDraw(ICashDispenser cashDispenser)
        {
            
        }

        public int[] GetBills()
        {
            return _bills;
        }
    }
}
