public class CommandsPrint
{
public static void PrintCommands()
    {
        Console.WriteLine("Available commands:");
        Console.WriteLine("/add - Add a new housing entry");
        Console.WriteLine("/get - Retrieve a housing entry by ID");
        Console.WriteLine("/getAll - Retrieve all housing entries");
        Console.WriteLine("/update - Update an existing housing entry by ID");
        Console.WriteLine("/delete - Delete a housing entry by ID");
        Console.WriteLine("/help - Shows how to work with app");
        Console.WriteLine("/load - load data from json storage");
        Console.WriteLine("7. Exit - Exit the application");

        Console.Write("Please enter your command as shown in the examples above: ");
    }
}