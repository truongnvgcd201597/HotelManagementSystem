namespace ASM2;

public class Customer : User
{
    private int customerID;
    private String customerName;
    private int customerPhone;

    public Customer(int customerId, string customerName, int customerPhone)
    {
        customerID = customerId;
        this.customerName = customerName;
        this.customerPhone = customerPhone;
    }

    public int CustomerId
    {
        get => customerID;
        set => customerID = value;
    }

    public string CustomerName
    {
        get => customerName;
        set => customerName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int CustomerPhone
    {
        get => customerPhone;
        set => customerPhone = value;
    }

    public void displayInformation()
    {
        
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