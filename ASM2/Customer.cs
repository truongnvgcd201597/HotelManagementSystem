namespace ASM2;

public class Customer : User
{
    private int customerID { get; set; }
    private String customerName { get; set; }
    private int customerPhone { get; set; }

    public Customer(int customerId, string customerName, int customerPhone)
    {
        customerID = customerId;
        this.customerName = customerName;
        this.customerPhone = customerPhone;
    }

    public void displayInformation()
    {
        Console.WriteLine($"Customer ID: {customerID}, Customer Name: {customerName}, Customer Phone {customerPhone}");
    }

    public override void login()
    {
        base.login();
    }

    public override void viewSystem()
    {
        base.viewSystem();
    }
}
