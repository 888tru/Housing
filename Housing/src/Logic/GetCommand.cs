using InputHandler;

public class GetCommand : ILogic
{
    public HRepository repo;
    public int id;
    public string[] Arguments;
    public Housing hous;

    public void GetHandller(HRepository repository)
    {
        // у инпутюзера взять айди и отправить в гетхайусинг 
        Arguments = UserInputHandler.userHandler();
        repo = repository;
        WorkWithRepo();
    }
    public void WorkWithRepo()
    {
        id = int.Parse(Arguments[0]);
        if (id != null)
        {
            return;
        }
        hous = repo.GetHousing(id);
        Console.WriteLine(hous);
    }

}