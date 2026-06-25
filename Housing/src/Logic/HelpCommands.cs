public class HelpCommands
{

    public static void Execute()
    {
        Console.WriteLine("Welcome to the Housing Management Application!");
        Console.WriteLine("Here are the available commands and how to use them:");
        Console.WriteLine();
        Console.WriteLine("1. /add - Add a new housing entry");
        Console.WriteLine("   Usage: /add <Type> <Country> <City> <Region> <Price> <Rooms> <Area>");
        Console.WriteLine("   Example: /add Apartment USA NewYork Manhattan 500000 3 120.5");
        Console.WriteLine();
        Console.WriteLine("2. /get - Retrieve a housing entry by ID");
        Console.WriteLine("   Usage: /get <ID>");
        Console.WriteLine("   Example: /get 1");
        Console.WriteLine();
        Console.WriteLine("3. /getAll - Retrieve all housing entries");
        Console.WriteLine("   Usage: /getAll");
        Console.WriteLine();
        Console.WriteLine("4. /update - Update an existing housing entry by ID");
        Console.WriteLine("   Usage: /update <ID> <Type> <Country> <City> <Region> <Price> <Rooms> <Area>");
        Console.WriteLine("   Example: /update 1 Apartment USA NewYork Manhattan 550000 3 125.0");
        Console.WriteLine();
        Console.WriteLine("5. delete - Delete a housing entry by ID");
        Console.WriteLine("   Usage: /delete <ID>");
        Console.WriteLine("   Example: /delete 1");
        Console.WriteLine();
        Console.WriteLine("6. /help - Shows how to work with the app");
        Console.WriteLine("   Usage: /help");
        Console.WriteLine();
        Console.WriteLine("7. /exit - Exit the application");
        Console.WriteLine("   Usage: /exit");
    }
}