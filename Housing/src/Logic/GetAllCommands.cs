public class GetAllCommands : ILogic
{
    public void Execute(IStorage repository)
    {
        Console.WriteLine(repository.GetAllHousing());
    }

}