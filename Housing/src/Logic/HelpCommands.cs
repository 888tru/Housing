public class HelpCommands
{
    public static void Execute()
    {
        Console.WriteLine();
        Console.WriteLine("+----------------------------------------------------------------------------+");
        Console.WriteLine("|       ПОЛНАЯ СПРАВКА - УПРАВЛЕНИЕ ЖИЛЫМИ ПОМЕЩЕНИЯМИ                       |");
        Console.WriteLine("+----------------------------------------------------------------------------+");
        Console.WriteLine();

        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|  ДОБАВИТЬ НОВОЕ ПОМЕЩЕНИЕ (/add)                                        |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| Обязательные параметры для ЛЮБОГО типа:                                 |");
        Console.WriteLine("|   -t <тип>        Тип помещения: house или flat                         |");
        Console.WriteLine("|   -co <страна>    Страна (например: Kazakhstan)                         |");
        Console.WriteLine("|   -c <город>      Город (например: Almaty)                              |");
        Console.WriteLine("|   -r <район>      Район (например: Alatau)                              |");
        Console.WriteLine("|   -p <цена>       Цена в тенге (целое число, > 0)                       |");
        Console.WriteLine("|   -ro <комнаты>   Количество комнат (целое число, >= 1)                 |");
        Console.WriteLine("|   -a <площадь>    Площадь в м² (число с точкой, например: 85.5)         |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| ДЛЯ ДОМА (house) нужны ещё два параметра:                               |");
        Console.WriteLine("|   -hf <этажи>     Количество этажей (целое число, >= 1)                 |");
        Console.WriteLine("|   -ld <участок>   Площадь участка в м² (число с точкой, >= 0)           |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| Пример для дома:                                                        |");
        Console.WriteLine("|   /add -t house -co Kazakhstan -c Almaty -r Alatau -p 50000000 \\       |");
        Console.WriteLine("|        -ro 4 -a 120.5 -hf 2 -ld 8.0                                     |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| ДЛЯ КВАРТИРЫ (flat) нужны ещё три параметра:                            |");
        Console.WriteLine("|   -f <этаж>       Этаж квартиры (целое число, >= 1)                     |");
        Console.WriteLine("|   -rcn <название> Название жилого комплекса (текст, например: Alatau)   |");
        Console.WriteLine("|   -rct <класс>    Класс ЖК: economy | comfort | business | premium      |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| Пример для квартиры:                                                    |");
        Console.WriteLine("|   /add -t flat -co Kazakhstan -c Almaty -r Bostandyk \\                 |");
        Console.WriteLine("|        -p 25000000 -ro 3 -a 85.0 -f 12 -rcn Alatau -rct comfort         |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine();

        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|  ПРОСМОТР ДАННЫХ                                                        |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| /get <ID>                                                               |");
        Console.WriteLine("|   Показать подробную информацию о помещении по ID                       |");
        Console.WriteLine("|   Пример: /get 5                                                        |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| /getAll                                                                 |");
        Console.WriteLine("|   Показать все помещения в базе данных                                  |");
        Console.WriteLine("|   Пример: /getAll                                                       |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine();

        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|  ОБНОВИТЬ ПОМЕЩЕНИЕ (/update)                                           |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| Используются те же флаги, что и при /add                                |");
        Console.WriteLine("| После ввода команды вас попросят указать ID помещения для обновления    |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| Пример:                                                                 |");
        Console.WriteLine("|   /update -t house -co Kazakhstan -c Almaty -r Alatau -p 45000000 \\  |");
        Console.WriteLine("|            -ro 3 -a 100.0 -hf 2 -ld 7.5                                 |");
        Console.WriteLine("|   Затем введите ID: 2                                                   |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine();

        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|  УДАЛЕНИЕ ДАННЫХ                                                        |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| /delete <ID>                                                            |");
        Console.WriteLine("|   Удалить одно помещение по ID                                          |");
        Console.WriteLine("|   Пример: /delete 3                                                     |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| /deleteAll                                                              |");
        Console.WriteLine("|   ОПАСНО! Удаляет ВСЕ помещения из базы                                 |");
        Console.WriteLine("|   Подтверждение НЕ требуется - действие необратимо!                     |");
        Console.WriteLine("|   Пример: /deleteAll                                                    |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| /deleteType <тип>                                                       |");
        Console.WriteLine("|   Удалить все помещения определённого типа (house или flat)             |");
        Console.WriteLine("|   Примеры: /deleteType house  или  /deleteType flat                     |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine();

        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|  СИСТЕМА И УТИЛИТЫ                                                      |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| /load                                                                   |");
        Console.WriteLine("|   Загрузить данные из JSON файла                                        |");
        Console.WriteLine("|   Пример: /load                                                         |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| /help                                                                   |");
        Console.WriteLine("|   Показать эту справку                                                  |");
        Console.WriteLine("|   Пример: /help                                                         |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("| /exit                                                                   |");
        Console.WriteLine("|   Выход из приложения                                                   |");
        Console.WriteLine("|   Пример: /exit                                                         |");
        Console.WriteLine("|                                                                         |");
        Console.WriteLine("+-------------------------------------------------------------------------+");
        Console.WriteLine();

        Console.WriteLine("+----------------------------------------------------------------------------+");
        Console.WriteLine("|  ПОЛЕЗНЫЕ СОВЕТЫ                                                           |");
        Console.WriteLine("+----------------------------------------------------------------------------+");
        Console.WriteLine("|  * Все флаги начинаются с дефиса: -t, -co, -c и т.д.                       |");
        Console.WriteLine("|  * Порядок флагов не важен                                                 |");
        Console.WriteLine("|  * Числа с точкой (площадь) используйте формат: 85.5                       |");
        Console.WriteLine("|  * Типы недвижимости: house (дом) или flat (квартира)                      |");
        Console.WriteLine("|  * Классы ЖК: economy, comfort, business, premium                          |");
        Console.WriteLine("|  * Введите /help в любой момент для повторного просмотра справки           |");
        Console.WriteLine("+----------------------------------------------------------------------------+");
        Console.WriteLine();
    }
}