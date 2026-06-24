public class GetAllCommands
{
    public HRepository repo;
    public void GetAllHandler(HRepository repository)
    {
        repo = repository;
        Console.WriteLine(repo.GetAllHousing);
    }
}