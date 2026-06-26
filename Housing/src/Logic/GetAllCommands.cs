public class GetAllCommands : ILogic
{
    public void Execute(IStorage repository, string[] args)
    {
        var housings = repository.GetAllHousing();

        if (!housings.Any())
        {
            Console.WriteLine("There are not any data in storage!");
            return;
        }
            foreach (var housing in housings)
        {
            Console.WriteLine(housing);
        }
    }

}