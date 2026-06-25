using InputHandler;

public class DeleteCommand : ILogic
{

    public void Execute(IStorage repo, string[] args){
        // у инпутюзера взять айди и отправить в гетхайусинг 
        string[] Arguments = args;
        int id = int.Parse(Arguments[0]);
        string Str = repo.DeleteHousing(id);
        Console.WriteLine(Str);
    }
   

}