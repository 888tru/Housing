public class CommandsPrint
{
public int PrintCommands()
    {
        Console.WriteLine("Available commands:");
        Console.WriteLine("1. Add - Add a new housing entry");
        Console.WriteLine("2. Get - Retrieve a housing entry by ID");
        Console.WriteLine("3. GetAll - Retrieve all housing entries");
        Console.WriteLine("4. Update - Update an existing housing entry by ID");
        Console.WriteLine("5. Delete - Delete a housing entry by ID");
        Console.WriteLine("6. Help - Shows how to work with app");
        Console.WriteLine("7. Exit - Exit the application");
        Console.WriteLine("Please enter your command as shown in the examples above.");
        return Console.Read(); 
    }
}