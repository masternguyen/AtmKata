namespace AtmKata.Model
{
    public interface IDab
    {      
        int[] NumberOfBills { get; set; }
        void WithDraw(ICashDispenser cashDispenser);
        int[] GetBills();
    }
}
