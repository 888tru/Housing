public class HelpCommands
{
    public static void Execute()
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║       СПРАВКА — УПРАВЛЕНИЕ ЖИЛЫМИ ПОМЕЩЕНИЯМИ                  ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine();

        Console.WriteLine("┌─  ДОБАВИТЬ НОВОЕ ПОМЕЩЕНИЕ ──────────────────────────────────┐");
        Console.WriteLine("│ Синтаксис:");
        Console.WriteLine("│   /add <тип> <страна> <город> <район> <цена> <комнат> <площадь> [доп]");
        Console.WriteLine("│");
        Console.WriteLine("│ Типы и дополнительные поля:");
        Console.WriteLine("│   house — дом (этажность площадь_участка)");
        Console.WriteLine("│     Пример: /add house Kazakhstan Almaty Alatau 50000000 4 120.5 2 8.0");
        Console.WriteLine("│");
        Console.WriteLine("│   flat  — квартира (этаж название_ЖК класс_ЖК)");
        Console.WriteLine("│     Классы: economy | comfort | business | premium");
        Console.WriteLine("│     Пример: /add flat Kazakhstan Almaty Bostandyk 25000000 3 85.0 12 Alatau comfort");
        Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
        Console.WriteLine();

        Console.WriteLine("┌─  ПРОСМОТР ДАННЫХ ──────────────────────────────────────────────┐");
        Console.WriteLine("│ /get <id>");
        Console.WriteLine("│   Показать одно жилое помещение по его ID");
        Console.WriteLine("│   Пример: /get 1");
        Console.WriteLine("│");
        Console.WriteLine("│ /getAll");
        Console.WriteLine("│   Показать все жилые помещения");
        Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
        Console.WriteLine();

        Console.WriteLine("┌─ ✏️ ОБНОВИТЬ ПОМЕЩЕНИЕ ──────────────────────────────────────────┐");
        Console.WriteLine("│ Синтаксис: /update <тип> <страна> <город> <район> <цена> <комн> <площадь> [доп]");
        Console.WriteLine("│ Те же параметры что и /add, но ID будет запрошен в процессе");
        Console.WriteLine("│ Пример: /update house Kazakhstan Almaty Alatau 50000000 4 120.5 2 8.0");
        Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
        Console.WriteLine();

        Console.WriteLine("┌─  УДАЛЕНИЕ ДАННЫХ ──────────────────────────────────────────────┐");
        Console.WriteLine("│ /delete <id>");
        Console.WriteLine("│   Удалить помещение по ID");
        Console.WriteLine("│   Пример: /delete 1");
        Console.WriteLine("│");
        Console.WriteLine("│ /deleteAll");
        Console.WriteLine("│   Удалить ВСЕ помещения (подтверждение не требуется!)");
        Console.WriteLine("│");
        Console.WriteLine("│ /deleteType <тип>");
        Console.WriteLine("│   Удалить все помещения определённого типа (house или flat)");
        Console.WriteLine("│   Примеры: /deleteType house  или  /deleteType flat");
        Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
        Console.WriteLine();

        Console.WriteLine("┌─  СИСТЕМА И УТИЛИТЫ ────────────────────────────────────────────┐");
        Console.WriteLine("│ /load");
        Console.WriteLine("│   Загрузить данные из JSON файла в хранилище");
        Console.WriteLine("│");
        Console.WriteLine("│ /help");
        Console.WriteLine("│   Показать эту справку");
        Console.WriteLine("│");
        Console.WriteLine("│ /exit");
        Console.WriteLine("│   Выход из приложения");
        Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
        Console.WriteLine();
        Console.WriteLine(" Совет: используйте /help в любой момент для просмотра справки");
        Console.WriteLine();
    }
}