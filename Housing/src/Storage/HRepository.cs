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
        return "Succesfully added!";
    }

    public string UpdateHousing(int id, Housing newHousing) {
        int index = arrHousing.FindIndex(h => h.Id == id);

        newHousing.Id = id;
        if (index >= 0)
        {
            arrHousing[index] = newHousing;
            return $"Updated where id is {id}";
        } 
        else
        {
            Console.WriteLine("Not found");
            return $"Not found with id: {id}";
        }
    }

    public string DeleteHousing(int id) {
        int elementsCount = arrHousing.RemoveAll(h => h.Id == id);
        if (elementsCount == 0) return "Not Found";
        else return "Deleted";
    }
    public Housing GetHousing(int id)
    {
        Housing housing = arrHousing.FirstOrDefault(h => h.Id == id);
        if (housing != null) return housing;
        else
        {
            Console.WriteLine("Not found");
            return null;
        }
    }
    public List<Housing> GetAllHousing()
    {
        return arrHousing;
    }
}
