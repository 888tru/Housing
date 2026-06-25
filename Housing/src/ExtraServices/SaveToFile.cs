using System.Text.Json;
public class SaveToFile
{
    public static void Save(List<Housing> arrHousing)
    {
        string filePath = "myStorage.json";
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(arrHousing, options);
        File.WriteAllText(filePath, jsonString);
        Console.WriteLine($"Saving to: {Path.GetFullPath(filePath)}");
    }
}