namespace InputHandler;
public class UserInputHandler
{
    public static string[] userHandler()
    {
        Console.Write("Please enter your command: ");
        string commands = Console.ReadLine();
        string[] arrOfCommands = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for (int i = 1; i <= arrOfCommands.Length; i++)
        {

        }
        
        return arrOfCommands;
    }
}