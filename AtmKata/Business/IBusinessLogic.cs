using AtmKata.Model;

namespace AtmKata.Business
{
    public interface IBusinessLogic
    {
        ICashDispenser WithDraw(string name, decimal amount);
        IDab GetDab();
        IAccount GetAccountByName(string name);
        decimal GetBalanceByName(string name);
    }
}
