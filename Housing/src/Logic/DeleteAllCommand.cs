public class DeleteAllTypeCommand : ILogic
{
    public void Execute(IStorage rep , string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter type");
            return;
        }
        Console.WriteLine("Enter type of housing that u want to delete");
        if (Enum.TryParse(args[0], out HousingType HType))
        {
            string Str = rep.DeleteHousingByType(HType);
            Console.WriteLine(Str);
        }
    }
}

public class DeleteAll : ILogic
{
    public void Execute(IStorage rep, string[] args)
    {
       string str = rep.DeleteAllHousing();
        Console.WriteLine(str);
    }
}