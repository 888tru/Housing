using InputHandler;

public class DeleteCommand : ILogic
{
    public HRepository repo;
    public int id;
    public string[] Arguments;

    public void DeleteHandler(HRepository repository)
    {
        // у инпутюзера взять айди и отправить в гетхайусинг 
        Arguments = UserInputHandler.userHandler();
        repo = repository;
        WorkWithRepo();
    }
    public void WorkWithRepo()
    {
        id = int.Parse(Arguments[0]);
        string Str = repo.DeleteHousing(id);
        Console.WriteLine(Str);
    }

}