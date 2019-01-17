using AtmKata.Model;
using AtmKata.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace AtmKata.Business
{
    class BusinessLogic : IBusinessLogic
    {
        private IDab _dab;
        private List<IAccount> _listeAccount;
        public BusinessLogic(IDab dab, List<IAccount> listeAccount)
        {
            _dab = dab;
            _listeAccount = listeAccount;
        }

        public ICashDispenser WithDraw(string name, decimal amount)
        {
            ICashDispenser cashDispenser = Factory.CreateCashDispenser();

            IAccount account = GetAccountByName(name);
            ITransaction withDraw = new WithDraw()
            {
                Account = account,
                Amount = amount
            };

            if (account.Balance < amount)
            {
                cashDispenser.IsSufficientBalance = false;
                return cashDispenser;
            }
            else
            {
                cashDispenser.IsSufficientBalance = true;
            }

            int[] bills = _dab.GetBills();

            for (int i = 0; i < bills.Length; i++)
            {

                if (!(amount < bills[i]))
                {
                    cashDispenser.NumberOfBills[i] = (int)amount / bills[i];
                    if (cashDispenser.NumberOfBills[i] > _dab.NumberOfBills[i])
                    {
                        cashDispenser.NumberOfBills[i] = _dab.NumberOfBills[i];
                    }
                    amount -= bills[i] * cashDispenser.NumberOfBills[i];
                }
            }

            if (amount > 10)
            {
                cashDispenser.IsSufficientCash = false;
                return cashDispenser;
            }
            else if (amount > 0 && amount < 10)
            {
                cashDispenser.IsValidAmount = false;
                return cashDispenser;
            }
            else
            {
                cashDispenser.IsSufficientCash = true;
                cashDispenser.IsValidAmount = true;
                cashDispenser.Dispense(_dab);
                withDraw.Execute();
                return cashDispenser;
            }

        }

        public IDab GetDab()
        {
            return _dab;
        }

        private IAccount GetAccountByName(string name)
        {
            return _listeAccount.FirstOrDefault(x => x.Name == name);
        }
        public decimal GetBalanceByName(string name)
        {
            return GetAccountByName(name).Balance;
        }
    }
}
