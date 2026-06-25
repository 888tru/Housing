using InputHandler;


public class CreateCommand : ILogic
{


    public  void Execute(IStorage repository, string[] Arguments)
    {

        // примерно будет вызываться в switc
        Housing hous = ArgsHandler.TypeChoosing(Arguments);
        string result =  repository.CreateHousing(hous);
        Console.WriteLine(result);
    }
  
}