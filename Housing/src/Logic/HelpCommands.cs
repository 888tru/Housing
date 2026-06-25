public class HelpCommands
{
    public static void Execute()
    {
        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║              HOUSING MANAGEMENT — СПРАВКА                    ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
        Console.WriteLine();

        Console.WriteLine("── ДОБАВИТЬ ────────────────────────────────────────────────────");
        Console.WriteLine("  /add <тип> <страна> <город> <район> <цена> <комнат> <площадь> [доп. поля]");
        Console.WriteLine();
        Console.WriteLine("  Тип: house | flat");
        Console.WriteLine();
        Console.WriteLine("  Для дома (house) — два доп. поля:");
        Console.WriteLine("    <этажность> <площадь_участка>");
        Console.WriteLine("    /add house Kazakhstan Almaty Alatau 50000000 4 120.5 2 8.0");
        Console.WriteLine();
        Console.WriteLine("  Для квартиры (flat) — три доп. поля:");
        Console.WriteLine("    <этаж> <название_ЖК> <класс_ЖК>");
        Console.WriteLine("    Классы ЖК: economy | comfort | business | premium");
        Console.WriteLine("    /add flat Kazakhstan Almaty Bostandyk 25000000 3 85.0 12 Alatau comfort");
        Console.WriteLine();

        Console.WriteLine("── ПРОСМОТР ─────────────────────────────────────────────────────");
        Console.WriteLine("  /get <id>       — показать одну запись");
        Console.WriteLine("  /getAll         — показать все записи");
        Console.WriteLine();

        Console.WriteLine("── ИЗМЕНЕНИЕ ────────────────────────────────────────────────────");
        Console.WriteLine("  /update <тип> <страна> <город> <район> <цена> <комнат> <площадь> [доп. поля]");
        Console.WriteLine("  (те же аргументы что у /add, ID спросит сам)");
        Console.WriteLine();

        Console.WriteLine("── УДАЛЕНИЕ ─────────────────────────────────────────────────────");
        Console.WriteLine("  /delete <id>    — удалить запись по ID");
        Console.WriteLine();

        Console.WriteLine("── ПРОЧЕЕ ───────────────────────────────────────────────────────");
        Console.WriteLine("  /load           — загрузить данные из файла");
        Console.WriteLine("  /help           — эта справка");
        Console.WriteLine("  /exit           — выход");
        Console.WriteLine();
    }
}