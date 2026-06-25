

public class UpdateCommands : ILogic
{

    public void Execute(IStorage repository, string[] args)

    {
        //  пока хзз как реализовать , но нужно будет передавать в метод UpdateHousing id и housing, который мы хотим обновить
        Console.Write("Enter ID to update: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Housing hous = ArgsHandler.TypeChoosing(args);
            repository.UpdateHousing(id, hous);
        }
        else
        {
            Console.WriteLine("Please enter integer");
        }


    }
}
