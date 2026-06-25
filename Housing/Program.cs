using InputHandler;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            IStorage repository = new HRepository();
            UserInputHandler userInputHandler = new UserInputHandler();
            while (true)
            {
                CommandsPrint.PrintCommands();
                string whichCommand = Console.ReadLine();

                if (!int.TryParse(whichCommand, out int id))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                switch (whichCommand)
                {
                    case "1":
                        ILogic createCommand = new CreateCommand();
                        createCommand.CreateHandler(repository);
                        break;
                    case "2":
                        GetCommand getCommand = new GetCommand();
                        getCommand.GetHandller(repository);
                        break;
                    case "3":
                        GetAllCommands getAllCommand = new GetAllCommands();
                        getAllCommand.GetAllHandler(repository);
                        break;
                    case "4":
                        UpdateCommands updateCommands = new UpdateCommands();
                        updateCommands.UpdateHandler(repository);
                        break;
                    case "5":
                        DeleteCommand deleteCommand = new DeleteCommand();
                        deleteCommand.DeleteHandler(repository);
                        break;
                    case "6":
                        HelpCommands.HelpHandler();
                        break;
                    case "7":
                        Console.WriteLine("Exiting the program.");
                        return;

                }


            }
        } catch(Exception ex) {
            Console.WriteLine(ex.Message);
            return;
        }
    }
}