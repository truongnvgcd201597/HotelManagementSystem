namespace ASM2;

public class Room
{
    private int roomID;
    private String roomType;
    private double roomPrice;
    private String roomStatus;

    public Room(int roomId, string roomType, double roomPrice, string roomStatus)
    {
        roomID = roomId;
        this.roomType = roomType;
        this.roomPrice = roomPrice;
        this.roomStatus = roomStatus;
    }

    public int RoomId
    {
        get => roomID;
        set => roomID = value;
    }

    public string RoomType
    {
        get => roomType;
        set => roomType = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double RoomPrice
    {
        get => roomPrice;
        set => roomPrice = value;
    }

    public string RoomStatus
    {
        get => roomStatus;
        set => roomStatus = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void roomInformation()
    {
        
    }
}
