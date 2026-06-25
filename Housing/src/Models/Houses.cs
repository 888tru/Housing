public class Houses : Housing
{
    public int HouseFloors { get; set; }
    public float LandArea { get; set; }

    public Houses(HousingType type, string country, string city, string region, int price, int rooms, float area, int houseFloors, float landArea)
        : base(type, country, city, region, price, rooms, area)
    {
        HouseFloors = houseFloors;
        LandArea = landArea;
    }


    public override string ToString() => $"""
    [ Информация об объекте ]
    ---------------------------------
    Тип:          {Type}
    Локация:      {Country}, {Region}, {City}
    Цена:         {Price:N0} KZT
    Параметры:    {Rooms} комн. | {Area} м
    Этажность:    {HouseFloors} эт.
    Участок:      {LandArea} сот.
    ---------------------------------
    """;

}