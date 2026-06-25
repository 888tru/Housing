using InputHandler;

public class UpdateCommands : ILogic
{

    public void Execute(IStorage repository)

    {
        string[] Aguments  = UserInputHandler.userHandler();
        Housing hous = ;
        repository.UpdateHousing(int.Parse(Aguments[0]), hous);

    }
}
