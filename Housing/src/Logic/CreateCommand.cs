using InputHandler;


public class CreateCommand : ILogic
{

    public HRepository repo;
    public Housing hous;


    public void CreateHandler(HRepository repository)
    {

        // примерно будет вызываться в switc
        repo = repository;
        WorkWithRepo();
    }
    public void WorkWithRepo()

    {
        hous = ArgsHandler.TypeChoosing();
        if (hous == null)
        {
            Console.WriteLine("Hous is null");
            return;
        }


            repo.CreateHousing(hous);

    }
}