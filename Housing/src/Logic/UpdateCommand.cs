using InputHandler;

public class UpdateCommands : ILogic
{
    public HRepository repo;
    public Housing housing;
    public string[] Arguments;


    public void UpdateHandler(HRepository repository)

    {
        repo = repository;
        WorkWithRepo();

    }
    public void WorkWithRepo()
    {
        Arguments = UserInputHandler.userHandler();
        int id = int.Parse(Arguments[0]);
        housing = ArgsHandler.TypeChoosing();
        repo.UpdateHousing(id, housing);

    }
}
