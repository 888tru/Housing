using InputHandler;

public class UpdateCommands : ILogic
{

    public void Execute(IStorage repository)

    {
        Console.Write("Enter ID to update: ");
        int id = int.Parse(Console.ReadLine());
        Housing hous = ArgsHandler.TypeChoosing();
        repository.UpdateHousing(id, hous);

    }
}
