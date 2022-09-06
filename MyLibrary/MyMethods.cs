namespace MyLibrary;
using static Message;

/// <summary>
/// Статический класс дополнительных методов.
/// </summary>
public static class MyMethods
{
    /// <summary>
    /// Делегат вывода сообщения в UI.
    /// </summary>
    /// <param name="msg">Сообщение для вывода в UI.</param>
    public delegate void MessageHandler(string msg);

    /// <summary>
    /// Метод консольного вывода сообщений.
    /// </summary>
    /// <param name="msg">Сообщение для вывода.</param>
    public static void ConsoleMessage(string msg) => Console.WriteLine(msg);

    /// <summary>
    /// Метод ввода через консоль. Возвращает int после проверок и преобразования.
    /// </summary>
    /// <param name="message">Одновременный вывод комментария в консоль. </param>
    /// <returns></returns>

    public static int GetConsoleInput(string message)
    {
        string? consoleInput = MyConsole.ReadLine(message); //  Кладём в переменную вводенные данные с консоли. Используем MyConsole для возможности одновременно использовать Console. Write

        if (int.TryParse(consoleInput, out var parseResult)) // Проверка на допустимость преобразования введенных символов в тип int.  
            return parseResult; // преобразование возможно - возвращаем int 
        else
            return GetConsoleInput(incorrect_input_msg); // преобразование невозможно - рекурсивно вызываем метод ввода, пока не будет корректного ввода
    }
    /// <summary>
    /// Метод получения утвердительного или отрицательного ввода: 'y' или 'n'.
    /// </summary>
    /// <param name="message"> Вывод в консоль комментария. </param>
    /// <returns></returns>

    public static bool GetYesOrNoConsoleInput(string message)
    {
        string? stringInput = MyConsole.ReadLine(message);
        if (stringInput?.ToLower() == checkedYes) // если ввод "y/Y" - продолжаем
        {
            return true;
        }
        else if (stringInput?.ToLower() == checkedNo) // если ввод "n/N" - завершаем.
        {
            return false;
        }

        else // если введен другой символ/символы
        {
            return GetYesOrNoConsoleInput(not_chosen_yes_or_no_msg); // рекурсивный вызов ввода y или n
        }
    }
}
