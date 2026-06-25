using InputHandler;

public class GetCommand : ILogic
{
    public void Execute(IStorage repository)
    {
        // у инпутюзера взять айди и отправить в гетхайусинг 
        string[] Arguments = UserInputHandler.userHandler();
       
        Housing hous = repository.GetHousing(int.Parse(Arguments[0]));
    }

}