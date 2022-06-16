namespace park_info;

public class ParkInfo
{
    public int ParkId { get; set; }

    public bool National { get; set; }

    public string Name { get; set; }

    public string State { get; set; }

    public ParkInfo(int parkId, bool national, string name, string state)
    {
        ParkId = parkId;
        National = national;
        Name = name;
        State = state;
    }
}

