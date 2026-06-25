using InputHandler;

public class UpdateCommands : ILogic
{

    public void Execute(IStorage repository, string[] args)

    {
        //  пока хзз как реализовать , но нужно будет передавать в метод UpdateHousing id и housing, который мы хотим обновить
        Console.Write("Enter ID to update: ");
        int id = int.Parse(Console.ReadLine());
        Housing hous = ArgsHandler.TypeChoosing(args);
        repository.UpdateHousing(id, hous);

    }
}
