namespace ASM2;

public class Cash : Payment
{
    private String cashAmount { get; set; }

    public Cash(int paymentID, String paymentMethod, String paymentStatus, String cashAmount) : base(paymentID, paymentMethod, paymentStatus)
    {
        this.cashAmount = cashAmount;
    }

    public void viewCash()
    {
        Console.WriteLine("Cash amount: " + cashAmount);
    }
}