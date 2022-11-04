namespace ASM2;

public class Admintrator : User
{
    public List<Customer> customerList = new List<Customer>();
    public List<Room> roomList = new List<Room>();

    public void addRoom()
    {
        Console.WriteLine("Add room ID: ");
        int roomID = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Add room type: ");
        String roomType = Console.ReadLine();
        Console.WriteLine("Add room price: ");
        double roomPrice = Double.Parse(Console.ReadLine());
        Console.WriteLine("Add room status: ");
        String roomStatus = Console.ReadLine();
        roomList.Add(new Room(roomID, roomType, roomPrice, roomStatus));
    }

    public void viewRoom()
    {
        foreach (Room room in roomList)
        {
            Console.WriteLine("Room ID: " + room.RoomId);
            Console.WriteLine("Room type: " + room.RoomType);
            Console.WriteLine("Room price: " + room.RoomPrice);
            Console.WriteLine("Room status: " + room.RoomStatus);
        }
    }
    public void editRoom()
    {
        Console.WriteLine("Enter room ID: ");
        int roomID = Int32.Parse(Console.ReadLine());
        foreach (Room room in roomList)
        {
            if (room.RoomId == roomID)
            {
                Console.WriteLine("Enter new room type: ");
                room.RoomType = Console.ReadLine();
                Console.WriteLine("Enter new room price: ");
                room.RoomPrice = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter new room status: ");
                room.RoomStatus = Console.ReadLine();
            }
        }
    }

    public void addCustomerInformation()
    {
        Console.WriteLine("Customer ID: ");
        int customerID = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Customer name: ");
        String customerName = Console.ReadLine();
        Console.WriteLine("Customer phone: ");
        int customerPhone = Int32.Parse(Console.ReadLine());
        customerList.Add(new Customer(customerID, customerName, customerPhone));
    }

    public void deleteCustomerInformation()
    {
        Console.WriteLine("Enter customer ID: ");
        int customerID = Int32.Parse(Console.ReadLine());
        foreach (Customer customer in customerList)
        {
            if (customer.CustomerId == customerID)
            {
                customerList.Remove(customer);
            }
        }
    }

    public void updateCustomerInformation()
    {
        Console.WriteLine("Enter customer ID: ");
        int customerID = Int32.Parse(Console.ReadLine());
        foreach (Customer customer in customerList)
        {
            if (customer.CustomerId == customerID)
            {
                Console.WriteLine("Enter new customer name: ");
                customer.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter new customer phone: ");
                customer.CustomerPhone = Int32.Parse(Console.ReadLine());
            }
        }
    }

    public void createReservation()
    {
    
    }

    public void showMenu()
    {
        
    }

    public void displayInformationCustomer()
    {
        foreach (Customer customer in customerList)
        {
            Console.WriteLine("Customer ID: " + customer.CustomerId);
            Console.WriteLine("Customer name: " + customer.CustomerName);
            Console.WriteLine("Customer phone: " + customer.CustomerPhone);
        }
    }

    public override void login()
    {
        Console.WriteLine("Enter username: ");
        String username = Console.ReadLine();
        Console.WriteLine("Enter password: ");
        String password = Console.ReadLine();
        if (username.Equals("admin") && password.Equals("admin"))
        {
            Console.WriteLine("Login successfully!");
            showMenu();
        }
        else
        {
            Console.WriteLine("Login failed!");
        }
    }

    public override void viewSystem()
    {
        Console.WriteLine("View system");
    }
}