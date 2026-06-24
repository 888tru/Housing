namespace InputHandler;
public class UserInputHandler
{
    public static string[] userHandler()
    {
        Console.Write("Please enter your command: ");
        string commands = Console.ReadLine();
        string[] arrOfCommands = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        if (Enum.Parse<HousingType>(arrOfCommands[1]) == HousingType.flat)
        {

        }
        for (int i = 1; i <= arrOfCommands.Length; i++)
        {

        }
        
        return arrOfCommands;
    }
}