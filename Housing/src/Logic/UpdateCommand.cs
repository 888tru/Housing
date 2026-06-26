

public class UpdateCommands : ILogic
{

    public void Execute(IStorage repository, string[] args)

    {
        var dict = FlagParser.FlagParse(args);
        if (!int.TryParse(FlagParser.GetRequared("id", dict), out int id) || id < 0) {
            throw new ArgumentException("please enter correct id");
        }
        else
        {
            Housing hous = ArgsHandler.TypeChoosing(args);
            repository.UpdateHousing(id, hous);
        }


    }
}
