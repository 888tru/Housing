public class Flats : Housing
{
    public int Floors { get; set; }
    public string ResCompName { get; set; }
    public ResComplxType ResComplxType { get; set; }

    public Flats(HousingType type, string country, string city, string region, int price, int rooms, float area, int floors, string resCompName, ResComplxType resComplxType)
        : base(type, country, city, region, price, rooms, area)
    {
        Floors = floors;
        ResCompName = resCompName;
        ResComplxType = resComplxType;
    }

    public override string ToString()
    {
       return $"Type: {Type}, Country: {Country}, City: {City}, Region: {Region}, Price: {Price}, Rooms: {Rooms}, Area: {Area}, Floors: {Floors}, Residential Complex Name: {ResCompName}, Residential Complex Type: {ResComplxType}";
    }

}


