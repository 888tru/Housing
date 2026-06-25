public class LoadCommand 
{
    public static void Execute(IStorage storage)
    {
        string result = storage.LoadFromFile();
        Console.WriteLine(result);
    }
}