namespace AtmKata.Model
{
    public class CashDispenser : ICashDispenser
    {

        public int[] NumberOfBills { get; set; }
        public bool IsValidAmount { get; set; }
        bool ICashDispenser.IsSufficientCash { get; set; }
        bool ICashDispenser.IsSufficientBalance { get; set; }

        public void Dispense(IDab dab)
        {
            for (int i = 0; i < dab.NumberOfBills.Length; i++)
                dab.NumberOfBills[i] -= NumberOfBills[i];
        }

    }
}
