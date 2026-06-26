public class CommandsPrint
{
    public static void PrintCommands()
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║            УПРАВЛЕНИЕ ЖИЛЫМИ ПОМЕЩЕНИЯМИ — КОМАНДЫ            ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine(" ОПЕРАЦИИ С ДАННЫМИ:");
        Console.WriteLine("  /add       — добавить новое жилое помещение");
        Console.WriteLine("  /get       — получить помещение по ID");
        Console.WriteLine("  /getAll    — показать все помещения");
        Console.WriteLine("  /update    — обновить помещение по ID");
        Console.WriteLine("  /delete    — удалить помещение по ID");
        Console.WriteLine("  /deleteAll — удалить все помещения");
        Console.WriteLine("  /deleteType — удалить все помещения определённого типа");
        Console.WriteLine();
        Console.WriteLine(" СИСТЕМА:");
        Console.WriteLine("  /load      — загрузить данные из JSON хранилища");
        Console.WriteLine("  /help      — подробная справка по командам");
        Console.WriteLine("  /exit      — выход из приложения");
        Console.WriteLine();
        Console.Write("Введите команду (например: /help для справки): ");
    }
}