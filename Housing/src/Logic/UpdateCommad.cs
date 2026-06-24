using InputHandler;

public class UpdateCommands
{
    public int id;
    public HRepository repo;
    public Housing housing;
    public string[] Arguments;


    public void UpdateHandler(HRepository repository)
    
    {
        repo = repository;
        Arguments = UserInputHandler.userHandler();

    }
    public void WorkWithRepo()
    {
        int id = int.Parse(Arguments[0]);
        HousingType type = Enum.Parse<HousingType>(Arguments[1]);
        string country = Arguments[2];
        string city = Arguments[3];
        string region = Arguments[4];
        int price = int.Parse(Arguments[5]);
        int rooms = int.Parse(Arguments[6]);
        float area = float.Parse(Arguments[7]);

        housing = new Housing(type, country, city, region, price, rooms, area);
        repo.UpdateHousing(id, housing);

    }
}