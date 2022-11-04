namespace ASM2;

public class Card : Payment
{
    private String cardNumber { get; set; }
    private String cardHolderName { get; set; }
    private String cardType { get; set; }
    private String cardExpiryDate { get; set; }
    private String cardCVV { get; set; }

    public Card(int paymentID, String paymentMethod, String paymentStatus, String cardNumber, String cardHolderName, String cardType, String cardExpiryDate, String cardCVV) : base(paymentID, paymentMethod, paymentStatus)
    {
        this.cardNumber = cardNumber;
        this.cardHolderName = cardHolderName;
        this.cardType = cardType;
        this.cardExpiryDate = cardExpiryDate;
        this.cardCVV = cardCVV;
    }

    public void viewCard()
    {
        Console.WriteLine("Card number: " + cardNumber);
        Console.WriteLine("Card holder name: " + cardHolderName);
        Console.WriteLine("Card type: " + cardType);
        Console.WriteLine("Card expiry date: " + cardExpiryDate);
        Console.WriteLine("Card CVV: " + cardCVV);
    } 
}