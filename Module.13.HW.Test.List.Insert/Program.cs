using System.Diagnostics;

namespace Module._13.HW.Test.List.Insert;

internal class Program
{
    // Объявим простой список с именами
    private static List<string> UsersNames = new List<string>()
    {
        "Фёдор",
        "Сергей",
        "Алесандр"
    };

    static void Main(string[] args)
    {
        var stopWatch = Stopwatch.StartNew(); // Запускаем таймер

        UsersNames.Insert(2, "Павел"); // Добавляем имя по индексу в середину списка

        Console.WriteLine($"Вставка в  словарь: {stopWatch.Elapsed.TotalMilliseconds}  мс"); // Выводим результат
    }
}
