public class CommandsList
{
    public void printCommands(string[] commands)
    {
        foreach (string command in commands)
        {
            Console.WriteLine(command);
        }
        Console.Write("Please enter ur commamd as on example: ");
    }
}