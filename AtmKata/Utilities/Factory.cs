using AtmKata.Business;
using AtmKata.ConsoleUI;
using AtmKata.Model;
using System.Collections.Generic;

namespace AtmKata.Utilities
{
    public static class Factory
    {

        public static int[] Bills = new int[] { 100, 50, 20, 10 };

        public static IDab CreatDab()
        {
            return new Dab(Bills)
            {
                NumberOfBills = new int[] { 2, 5, 10, 10 }
            };
        }

        public static ICashDispenser CreateCashDispenser()
        {
            ICashDispenser cashDispenser = new CashDispenser();
            cashDispenser.NumberOfBills = new int[Bills.Length];
            return cashDispenser;
        }

        public static List<IAccount> CreateListAccount()
        {
            var listAccount = new List<IAccount>();
            var alice = new Account()
            {
                Id = 1,
                Name = "Alice",
                Balance = 1500
            };


            var jean = new Account()
            {
                Id = 2,
                Name = "Jean",
                Balance = 1500
            };
            var paul = new Account()
            {
                Id = 3,
                Name = "Paul",
                Balance = 50
            };

            listAccount.Add(alice);
            listAccount.Add(jean);
            listAccount.Add(paul);
            return listAccount;

        }
        public static IBusinessLogic CreateBusiness()
        {
            return new BusinessLogic(CreatDab(), CreateListAccount());
        }

        public static IApplication CreateApplication()
        {
            return new Application(CreateBusiness());
        }
    }
}
