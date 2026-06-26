using System.Text.Json;
public class SaveToFile
{
    public static void Save(List<Housing> arrHousing)
    {
        string filePath = "myStorage.json";
        string txtFilePath = "myStorage.txt";

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(arrHousing, options);
        File.WriteAllText(filePath, jsonString);
        Console.WriteLine($"Saving to: {Path.GetFullPath(filePath)}");

        string txtString = string.Join("\n", arrHousing);
        File.WriteAllText(txtFilePath, txtString);
        Console.WriteLine($"Saving to: {Path.GetFullPath(txtFilePath)}");
    }
}