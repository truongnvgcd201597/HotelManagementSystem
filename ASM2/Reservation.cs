namespace ASM2;

public class Reservation
{
    internal Customer _customer;
    internal Payment _payment;
    private DateOnly DateIn;
    private DateOnly DateOut;
    private String roomStatus;
    private int roomQuantity;

    public Customer Customer
    {
        get => _customer;
        set => _customer = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Payment Payment
    {
        get => _payment;
        set => _payment = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateOnly DateIn1
    {
        get => DateIn;
        set => DateIn = value;
    }

    public DateOnly DateOut1
    {
        get => DateOut;
        set => DateOut = value;
    }

    public string RoomStatus
    {
        get => roomStatus;
        set => roomStatus = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int RoomQuantity
    {
        get => roomQuantity;
        set => roomQuantity = value;
    }

    public void addCustomer()
    {
        
    }

    public void addPayment()
    {
        
    }

    public void addBookingDetail()
    {
        Console.WriteLine("Enter date in: ");
        DateIn = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter date out: ");
        DateOut = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter room status: ");
        roomStatus = Console.ReadLine();
        Console.WriteLine("Enter room quantity: ");
        roomQuantity = Int32.Parse(Console.ReadLine());
        
    }

    public void viewAvaiableRoom()
    {
        
    }
}