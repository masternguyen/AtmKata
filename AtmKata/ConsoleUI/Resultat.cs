using AtmKata.Model;
using System.Text;

namespace AtmKata.ConsoleUI
{
    public static class Resultat
    {
        public static string ListOfBill(ICashDispenser cashDispenser, IDab dab)
        {

            if (!cashDispenser.IsSufficientBalance)
            {
                return "Solde insufisant";
            }
            else if (!cashDispenser.IsSufficientCash)
            {
                return "Billets dans Dab insufissant";
            }
            else if (!cashDispenser.IsValidAmount)
            {
                return "Quantite invalide";
            }
            else
            {
                StringBuilder reponse = new StringBuilder();

                for (int i = 0; i < cashDispenser.NumberOfBills.Length; i++)
                    if (cashDispenser.NumberOfBills[i] > 0)
                    {
                        reponse.Append(" " + cashDispenser.NumberOfBills[i] + " x " + dab.GetBills()[i]);
                    }

                return reponse.ToString();
            }


        }

        public static string DabStock(IDab dab)
        {
            StringBuilder reponse = new StringBuilder();

            for (int i = 0; i < dab.NumberOfBills.Length; i++)
                reponse.Append(dab.NumberOfBills[i] + "x" + dab.GetBills()[i] + "  ");

                return reponse.ToString();

        }
    }
}
