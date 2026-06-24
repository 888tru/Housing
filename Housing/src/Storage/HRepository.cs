public class HRepository
{
    List<Housing> arrHosing = new List<Housing>();
    int id;

    public string CreateHousing(Housing housing)
    {
        housing.Id = id++;
        arrHosing.Add(housing);
        if (arrHosing.Count == 0) return "Not added smth is incorrect";
        else return "Succesfully added!";
    }

    public string UpdateHousing(int id, Housing newHousing) {
        Housing housing = arrHosing.FirstOrDefault(h => h.Id == id);
        newHousing.Id = id;
        housing = newHousing;
        if (housing != null) return $"Updated where id is {id}";
        else
        {
            Console.WriteLine("Not found");
            return $"Not found with id: {id}";
        }
    }

    public string DeleteHousing(int id) {
        int elementsCount = arrHosing.RemoveAll(h => h.Id == id);
        if (elementsCount == 0) return "Not Found";
        else return "Deleted";
    }
    public Housing GetHousing(int id)
    {
        Housing housing = arrHosing.FirstOrDefault(h => h.Id == id);
        if (housing != null) return housing;
        else
        {
            Console.WriteLine("Not found");
            return null;
        }
    }
    public List<Housing> GetAllHousing()
    {
        return arrHosing;
    }
}