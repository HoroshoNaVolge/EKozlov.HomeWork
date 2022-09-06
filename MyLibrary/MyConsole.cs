namespace MyLibrary; 

/// <summary>
/// Обёртка для типа System.Console
/// </summary>
public static class MyConsole
{
    /// <summary>
    /// Перегруженный метод с аргументом для вывода в консоль одновременно с запросом ввода пользователя 
    /// </summary>
    /// <param name="message"> Сообщение для вывода в консоль.</param>
    /// <returns></returns>
    public static string? ReadLine(string message)  // Допускаем NULL при помощи <string?>.
    {
        System.Console.Write(message); // Выдаем сообщение в консоль. 
        return System.Console.ReadLine(); // Запрос ввода пользователя в консоль.
    }
}
