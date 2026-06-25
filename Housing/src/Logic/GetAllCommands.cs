public class GetAllCommands : ILogic
{
    public void Execute(IStorage repository)
    {
        foreach (var housing in repository.GetAllHousing())
        {
            Console.WriteLine(housing);
        }
    }

}