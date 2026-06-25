

public class DeleteCommand : ILogic
{

    public void Execute(IStorage repo, string[] args){
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter id");
            return;
        }
        // у инпутюзера взять айди и отправить в тхайусинг 
        if(int.TryParse(args[0], out int id)){
            string Str = repo.DeleteHousing(id);
            Console.WriteLine(Str);
        }
        
    }
   

}