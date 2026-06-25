public class GetAllCommands : ILogic
{
    public HRepository repo;
    public void GetAllHandler(HRepository repository)
    {
        repo = repository;
        WorkWithRepo();
    }
    public void WorkWithRepo()
    {
        Console.WriteLine(repo.GetAllHousing());
    }
}