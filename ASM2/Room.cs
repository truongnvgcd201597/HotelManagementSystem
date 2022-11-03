namespace ASM2;

public class Room
{
    private int roomID { get; set; }
    private String roomType { get; set; }
    private double roomPrice { get; set; }
    private String roomStatus { get; set; }

    public Room(int roomId, string roomType, double roomPrice, string roomStatus)
    {
        roomID = roomId;
        this.roomType = roomType;
        this.roomPrice = roomPrice;
        this.roomStatus = roomStatus;
    }

    public void roomInformation()
    {
        Console.WriteLine($"Room ID: {roomID}, Room Type: {roomType}, Room Price {roomPrice}, Room Status: {roomStatus}");
    }
}
