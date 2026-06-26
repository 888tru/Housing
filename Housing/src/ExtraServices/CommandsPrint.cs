public class CommandsPrint
{
    public static void PrintCommands()
    {
        Console.WriteLine();
        Console.WriteLine("+----------------------------------------------------------------------------+");
        Console.WriteLine("|            УПРАВЛЕНИЕ ЖИЛЫМИ ПОМЕЩЕНИЯМИ - КОМАНДЫ                         |");
        Console.WriteLine("+----------------------------------------------------------------------------+");
        Console.WriteLine();

        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("| ОСНОВНЫЕ ОПЕРАЦИИ                                                       |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("|  /add        - Добавить новое помещение                                 |");
        Console.WriteLine("|  /get        - Получить помещение по ID                                 |");
        Console.WriteLine("|  /getAll     - Показать все помещения                                   |");
        Console.WriteLine("|  /update     - Обновить данные помещения                                |");
        Console.WriteLine("|  /delete     - Удалить помещение по ID                                  |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine();

        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("| РАСШИРЕННЫЕ ОПЕРАЦИИ                                                    |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("|  /deleteAll  - Удалить ВСЕ помещения (необратимо!)                      |");
        Console.WriteLine("|  /deleteType - Удалить все помещения по типу (house/flat)               |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine();

        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("| СИСТЕМА                                                                 |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("|  /load       - Загрузить данные из JSON файла                           |");
        Console.WriteLine("|  /help       - Подробная справка по всем командам                       |");
        Console.WriteLine("|  /exit       - Выход из приложения                                      |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine();
        Console.WriteLine("Доступные флаги: -t | -co | -c | -r | -p | -ro | -a | -hf | -ld | -f | -rcn | -rct");
        Console.WriteLine();

        Console.WriteLine("Введите /help для полной справки с примерами команд и описанием флагов");
        Console.WriteLine("Например: /help");
        Console.WriteLine();
        Console.Write("Введите команду: ");
    }
}