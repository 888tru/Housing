using InputHandler;

public class ArgsHandler
{
    public static Housing TypeChoosing()
    {
        try
        {
            string[] Arguments = UserInputHandler.userHandler();
            if (Arguments.Length < 8)
            {
                Console.WriteLine("Not enough arguments");
                return null;
            }
            HousingType hType = Enum.Parse<HousingType>(Arguments[1]);
            string country = Arguments[2];
            string city = Arguments[3];
            string region = Arguments[4];
            int price = int.Parse(Arguments[5]);
            int rooms = int.Parse(Arguments[6]);
            float area = float.Parse(Arguments[7]);
            string type = Arguments[0];
            switch (type)
            {
                case "house":
                    int houseFloors = int.Parse(Arguments[8]);
                    float landArea = float.Parse(Arguments[9]);
                    Housing house = new Houses(hType, country, city, region, price, rooms, area, houseFloors, landArea);
                    return house;

                case "flat":
                    int floors = int.Parse(Arguments[8]);
                    string resCompName = Arguments[9];
                    ResComplxType resComplxType = Enum.Parse<ResComplxType>(Arguments[10]);
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
