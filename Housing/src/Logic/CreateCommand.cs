using InputHandler;


public class CreateCommand
{

    public string[] Arguments;
    public HRepository repo;
    public Housing hous;


    public  void CreateHandler(HRepository repository)
    {
        
        // примерно будет вызываться в switch
        Arguments = UserInputHandler.userHandler();
        repo = repository;
        WorkWithRepo();
    }
    public void WorkWithRepo()

    {
        HousingType type = Enum.Parse<HousingType>(Arguments[1]); 
       
        string country = Arguments[2];
        string city = Arguments[3];
        string region = Arguments[4];
        int price = int.Parse(Arguments[5]);
        int rooms = int.Parse(Arguments[6]);
        float area = float.Parse(Arguments[7]);


        hous = new Housing(type, country, city, region, price, rooms, area);
        repo.CreateHousing(hous);

    }
}