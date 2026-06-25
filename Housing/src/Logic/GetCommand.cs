using InputHandler;

public class GetCommand : ILogic
{
    public void Execute(IStorage repository, string[] args)
    {
        // у инпутюзера взять айди и отправить в гетхайусинг 
        string[] Arguments = args;
       
        Console.WriteLine(repository.GetHousing(int.Parse(Arguments[0])));
    }

}