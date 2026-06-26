public interface IStorage
{
    string CreateHousing(Housing housing);
    Housing GetHousing(int id);
    List<Housing> GetAllHousing();
    string UpdateHousing(int id, Housing housing);
    string DeleteHousing(int id);
    string LoadFromFile();
    string DeleteAllHousing();
    string DeleteHousingByType(HousingType type);
}