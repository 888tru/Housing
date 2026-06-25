using InputHandler;

public class ArgsHandler
{
    public static Housing TypeChoosing(string[] strings)
    {
        try
        {
            string[] Arguments = strings;
            if (Arguments.Length < 8)
            {
                Console.WriteLine("Not enough arguments");
                return null;
            }
            HousingType hType = Enum.Parse<HousingType>(Arguments[0]);
            string country = Arguments[1];
            string city = Arguments[2];
            string region = Arguments[3];
            int price = int.Parse(Arguments[4]);
            int rooms = int.Parse(Arguments[5]);
            float area = float.Parse(Arguments[6], System.Globalization.CultureInfo.InvariantCulture);
            switch (hType)
            {
                case HousingType.house:
                    int houseFloors = int.Parse(Arguments[7]);
                    float landArea = float.Parse(Arguments[8], System.Globalization.CultureInfo.InvariantCulture);
                    Housing house = new Houses(hType, country, city, region, price, rooms, area, houseFloors, landArea);
                    return house;

                case HousingType.flat:
                    int floors = int.Parse(Arguments[7]);
                    string resCompName = Arguments[8];
                    ResComplxType resComplxType = Enum.Parse<ResComplxType>(Arguments[9]);
                    Housing flat = new Flats(hType, country, city, region, price, rooms, area, floors, resCompName, resComplxType);
                    return flat;
                default:
                    Console.WriteLine("Invalid housing type");
                    return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
}
}
