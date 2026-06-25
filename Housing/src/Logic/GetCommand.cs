using InputHandler;

public class GetCommand : ILogic
{
    public void Execute(IStorage repository)
    {
        // у инпутюзера взять айди и отправить в гетхайусинг 
        string[] Arguments = UserInputHandler.userHandler();
       
        Console.WriteLine(repository.GetHousing(int.Parse(Arguments[0])));
    }

}