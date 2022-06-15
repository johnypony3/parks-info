namespace park_info;

public class ParkInfo
{
    public bool National { get; set; }

    public string Name { get; set; }

    public string State { get; set; }

    public ParkInfo(bool national, string name, string state)
    {
        National = national;
        Name = name;
        State = state;
    }
}

