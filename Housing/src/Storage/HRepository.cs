
using System.Text.Json;

public class HRepository : IStorage
{
    List<Housing> arrHousing = new List<Housing>();
    int id;

    public string CreateHousing(Housing housing)
    {


        if (housing == null)
        {
            return "Housing object cannot be null";
        }
        housing.Id = id++;
        arrHousing.Add(housing);
        SaveToFile.Save(arrHousing);
        return "Succesfully added!";
    }

    public string UpdateHousing(int id, Housing newHousing) {
        int index = arrHousing.FindIndex(h => h.Id == id);

        newHousing.Id = id;
        if (index >= 0)
        {
            arrHousing[index] = newHousing;
            SaveToFile.Save(arrHousing);
            return $"Updated where id is {id}";
        } 
        else
        {
            return $"Not found with id: {id}";
        }
    }

    public string DeleteHousing(int id) {
        int elementsCount = arrHousing.RemoveAll(h => h.Id == id);
        
        if (elementsCount == 0) return $"house with this id:{id} not exists";
        else
        {
            SaveToFile.Save(arrHousing);
            return "Deleted";
        }
    }
    public Housing GetHousing(int id)
    {
        Housing housing = arrHousing.FirstOrDefault(h => h.Id == id);
        return housing;
    }
    public List<Housing> GetAllHousing()
    {
        return arrHousing;
    }


    public string LoadFromFile() {
        string filePath = "myStorage.json";
        if (!File.Exists(filePath))
        {
            return "No saved data found.";
        }
        string jsonString = File.ReadAllText(filePath);
        var loaded = JsonSerializer.Deserialize<List<Housing>>(jsonString);
        arrHousing = loaded ?? new List<Housing>();
        id = arrHousing.Count > 0 ? arrHousing.Max(h => h.Id) + 1 : 0;
        return "Data loaded successfully.";
    }

    public string DeleteAllHousing()
    {
        arrHousing.Clear();
        return "Now storage is empty";
    }
    public string DeleteHousingByType(HousingType type)
    {
        int elementsCount = arrHousing.RemoveAll(h => h.Type == type);
       
        if (elementsCount == 0) return $"housings with this type:{type} not exists";
        else
        {
            SaveToFile.Save(arrHousing);
            return "Deleted";
        }
    }
}
