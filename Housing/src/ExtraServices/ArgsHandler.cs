

public class ArgsHandler
{
    public static Housing TypeChoosing(string[] args)
    {
        try
        {
            var dict = FlagParser.FlagParse(args);

            if(!Enum.TryParse<HousingType>(FlagParser.GetRequared("t", dict), out HousingType hType)) 
                throw new ArgumentException("Please enter in format!");

            string country = FlagParser.GetRequared("co", dict);
            string city = FlagParser.GetRequared("c", dict);
            string region = FlagParser.GetRequared("r", dict);

            if(!int.TryParse(FlagParser.GetRequared("p", dict), out int price) || price <= 0) 
                throw new ArgumentException("Please enter price number in int-possitive format!");

            if (!int.TryParse(FlagParser.GetRequared("ro", dict), out int rooms) || rooms < 1) 
                throw new ArgumentException("Please enter price number in int-possitive format!");

            if (!float.TryParse(FlagParser.GetRequared("a", dict), System.Globalization.CultureInfo.InvariantCulture, out float area) || area <= 0) 
                throw new ArgumentException("Please enter price number in int-possitive format!");

            switch (hType)
            {
                case HousingType.house:
                    if (!int.TryParse(FlagParser.GetRequared("hf", dict), out int houseFloors) || houseFloors < 1) 
                        throw new ArgumentException("Please enter price number in int-possitive format!");

                    if (!float.TryParse(FlagParser.GetRequared("ld", dict), System.Globalization.CultureInfo.InvariantCulture, out float landArea) || landArea < 0) 
                        throw new ArgumentException("Please enter price number in int-possitive format!");

                    Housing house = new Houses(hType, country, city, region, price, rooms, area, houseFloors, landArea);
                    return house;

                case HousingType.flat:
                    if (!int.TryParse(FlagParser.GetRequared("f", dict), out int floors) || floors < 1) 
                        throw new ArgumentException("Please enter price number in int-possitive format!");

                    string resCompName = FlagParser.GetRequared("rcn", dict);

                    if(!Enum.TryParse<ResComplxType>(FlagParser.GetRequared("rct", dict), out ResComplxType resComplx)) 
                        throw new ArgumentException("Please enter complex type in correct format!");

                    Housing flat = new Flats(hType, country, city, region, price, rooms, area, floors, resCompName, resComplx);
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
