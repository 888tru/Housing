using InputHandler;


public class CreateCommand : ILogic
{


    public  void Execute(IStorage repository)
    {

        // примерно будет вызываться в switc
        Housing hous = ArgsHandler.TypeChoosing();
        repository.CreateHousing(hous);
    }
  
}