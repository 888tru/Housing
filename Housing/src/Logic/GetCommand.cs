

public class GetCommand : ILogic
{
    public void Execute(IStorage repository, string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter id");
            return;
        }
        // у инпутюзера взять айди и отправить в гетхайусинг
        if (int.TryParse(args[0], out int id) )
        {
            var hous = repository.GetHousing(id);
            if (hous != null) Console.WriteLine(hous);
            else Console.WriteLine($"Housing with id {id} not found.");
        }
        else
        {
            Console.WriteLine("Please enter integer");
        }
        
    }

}