

public class ArgsHandler
{
    public static Housing TypeChoosing(string[] args)
    {
        try
        {
            var dict = FlagParser.FlagParse(args);
            //if (Arguments.Length < 8)
            //{
            //    Console.WriteLine("Not enough arguments");
            //    return null;
            //}
            HousingType hType = Enum.Parse<HousingType>(dict["-t"]);
            string country = dict["-co"];
            string city = dict["-c"];
            string region = dict["-r"];
            if(int.TryParse(dict["-p"], out int price) || price < 0); Console.WriteLine("Please enter price number in int-possitive format!");
            if (!int.TryParse(dict["-ro"], out int rooms) || rooms < 1) Console.WriteLine("Please enter room number in int-possitive format!");
            if (!float.TryParse(dict["-a"], System.Globalization.CultureInfo.InvariantCulture, out float area)) Console.WriteLine("Please enter area in float format!");
            switch (hType)
            {
                case HousingType.house:
                    if (!int.TryParse(dict["-hf"], out int houseFloors) || houseFloors < 1) Console.WriteLine("Enter the number of floors in house correctly(possitive and int)");
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
