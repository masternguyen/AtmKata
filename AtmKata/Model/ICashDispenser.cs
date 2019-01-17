namespace AtmKata.Model
{
    public interface ICashDispenser
    {
        int[] NumberOfBills { get; set; }
        bool IsValidAmount { get; set; }
        bool IsSufficientCash { get; set; }
        bool IsSufficientBalance { get; set; }
        void Dispense(IDab dab);
    }
}