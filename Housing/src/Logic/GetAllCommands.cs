public class GetAllCommands : ILogic
{
    public void Execute(IStorage repository, string[] args)
    {
        foreach (var housing in repository.GetAllHousing())
        {
            Console.WriteLine(housing);
        }
    }

}