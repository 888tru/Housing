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

                if (!int.TryParse(whichCommand, out int id) || (1 > id || id > 7))
                {
                   
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                else
                {
                    switch (id)
                    {
                        case 1:
                            {
                                CreateCommand command = new CreateCommand();
                                command.Execute(repository);
                                break;
                            }
                        case 2:
                            {
                                GetCommand command = new GetCommand();
                                command.Execute(repository);
                                break;
                            }
                        case 3:
                            {
                                GetAllCommands command = new GetAllCommands();
                                command.Execute(repository);
                                break;
                            }

                        case 4:
                            {
                                UpdateCommands commands = new UpdateCommands();
                                commands.Execute(repository);
                                break;
                            }
                        case 5:
                            {
                                DeleteCommand command = new DeleteCommand();
                                command.Execute(repository);
                                break;
                            }

                        case 6:
                            {
                                HelpCommands.Execute();
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("Exiting the program.");
                                return;
                            } 
                }


            }
        }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
            return;
        }
    }
}