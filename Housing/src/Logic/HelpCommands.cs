public class HelpCommands
{
    public static void HelpHandler()
    {
        WorkWithRepo();
    }
    public static void WorkWithRepo()
    {
        Console.WriteLine("Welcome to the Housing Management Application!");
        Console.WriteLine("Here are the available commands and how to use them:");
        Console.WriteLine();
        Console.WriteLine("1. Add - Add a new housing entry");
        Console.WriteLine("   Usage: Add <Type> <Country> <City> <Region> <Price> <Rooms> <Area>");
        Console.WriteLine("   Example: Add Apartment USA NewYork Manhattan 500000 3 120.5");
        Console.WriteLine();
        Console.WriteLine("2. Get - Retrieve a housing entry by ID");
        Console.WriteLine("   Usage: Get <ID>");
        Console.WriteLine("   Example: Get 1");
        Console.WriteLine();
        Console.WriteLine("3. GetAll - Retrieve all housing entries");
        Console.WriteLine("   Usage: GetAll");
        Console.WriteLine();
        Console.WriteLine("4. Update - Update an existing housing entry by ID");
        Console.WriteLine("   Usage: Update <ID> <Type> <Country> <City> <Region> <Price> <Rooms> <Area>");
        Console.WriteLine("   Example: Update 1 Apartment USA NewYork Manhattan 550000 3 125.0");
        Console.WriteLine();
        Console.WriteLine("5. Delete - Delete a housing entry by ID");
        Console.WriteLine("   Usage: Delete <ID>");
        Console.WriteLine("   Example: Delete 1");
        Console.WriteLine();
        Console.WriteLine("6. Help - Shows how to work with the app");
        Console.WriteLine("   Usage: Help");
        Console.WriteLine();
        Console.WriteLine("7. Exit - Exit the application");
        Console.WriteLine("   Usage: Exit");
    }
}