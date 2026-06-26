

public class UpdateCommands : ILogic
{

    public void Execute(IStorage repository, string[] args)

    {
        var dict = FlagParser.FlagParse(args);
        if (!int.TryParse(dict["id"], out int id)) {
            throw new ArgumentException("please enter correct id");
        }
        else
        {
            Housing hous = ArgsHandler.TypeChoosing(args);
            repository.UpdateHousing(id, hous);
        }


    }
}
