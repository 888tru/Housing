

public class Program
{
    public static void Main(string[] args)
    {
        
            IStorage repository = new HRepository();
            while (true)
            {
                try
                {

                    CommandsPrint.PrintCommands();

                    string input = Console.ReadLine();
                    Console.WriteLine();
                    string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 0)
                    {
                        Console.WriteLine("No command entered. Please try again.");
                        continue;
                    }

                    string whichCommand = parts[0];
                    string[] Argumets = parts.Skip(1).ToArray();



                    switch (whichCommand)
                    {
                        case "/add":
                        {
                            CreateCommand command = new CreateCommand();
                            command.Execute(repository, Argumets);
                            break;
                        }
                        case "/get":
                        {
                            GetCommand command = new GetCommand();
                            command.Execute(repository, Argumets);
                            break;
                        }
                        case "/getAll":
                        {
                            GetAllCommands command = new GetAllCommands();
                            command.Execute(repository, Argumets);
                            break;
                        }

                        case "/update":
                        {
                            UpdateCommands commands = new UpdateCommands();
                            commands.Execute(repository, Argumets);
                            break;
                        }
                        case "/delete":
                        {
                            DeleteCommand command = new DeleteCommand();
                            command.Execute(repository, Argumets);
                            break;
                        }
                        case "/deleteAll":
                        {
                            DeleteAll command = new DeleteAll();
                            command.Execute(repository, Argumets);
                            break;
                        }
                    case "deleteType":
                        {
                            DeleteAllTypeCommand command = new DeleteAllTypeCommand();
                            command.Execute(repository, Argumets);
                            break;
                        }


                        case "/help":
                        {
                            HelpCommands.Execute();
                            break;
                        }
                        case "/load":
                        {
                            LoadCommand.Execute(repository);
                            break;
                        }

                        case "/exit":
                        {
                            Console.WriteLine("Exiting the program.");
                            return;
                        }
                        default:
                        {
                            Console.WriteLine("Please enter correct command from list");
                            break;
                        }
                    }
                    

                }catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

    }
}