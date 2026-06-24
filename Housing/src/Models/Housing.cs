public class Housing
{
    public int Id {  get; set; }
    public HousingType Type { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public int Price { get; set; }
    public int Rooms { get; set; }
    public float Area { get; set; }

    public Housing(HousingType type, string country, string city, string region, int price, int rooms, float area)
    {
        Type = type;
        Country = country;
        City = city;
        Region = region;
        Price = price;
        Rooms = rooms;
        Area = area;
    }
}