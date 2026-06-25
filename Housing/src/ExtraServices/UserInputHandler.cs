namespace InputHandler;
public class UserInputHandler
{
    public static string[] userHandler()
    {
        CommandsPrint.PrintCommands();
        string input = Console.ReadLine();
        string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] Argumets = parts.Skip(1).ToArray();



        return Argumets;
    }
}