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
    /// Делегат ввода данных из UI.
    /// </summary>
    /// <param name="msg">Сообщение для вывода в UI.</param>
    public delegate int InputHandler(string msg);

    /// <summary>
    /// Делегат ввода 'да' или 'нет' из UI.
    /// </summary>
    /// <param name="msg">Сообщение для вывода в UI.</param>
    public delegate bool YesOrNoInputHandler(string msg);
  
    /// <summary>
    /// Метод консольного вывода сообщений.
    /// </summary>
    /// <param name="msg">Сообщение для вывода.</param>
    public static void ConsoleMessage(string msg) => Console.WriteLine(msg);

    /// <summary>
    /// Метод ввода через консоль. Возвращает int после проверок и преобразования.
    /// </summary>
    /// <param name="message">Cообщение для вывода в консоль. </param>
    public static int GetConsoleInput(string message)
    {
        string consoleInput = MyConsole.ReadLine(message); //  Кладём в переменную вводенные данные с консоли. Используем MyConsole для возможности одновременно использовать Console. Write

        if (int.TryParse(consoleInput, out var parseResult)) // Проверка на допустимость преобразования введенных символов в тип int.  
            return parseResult; // преобразование возможно - возвращаем int 
        else
            return GetConsoleInput(INVALID_INPUT_MSG); // преобразование невозможно - рекурсивно вызываем метод ввода, пока не будет корректного ввода
    }

    /// <summary>
    /// Метод получения через консоль утвердительного или отрицательного ввода: 'y' или 'n'.
    /// </summary>
    /// <param name="message"> Вывод в консоль комментария. </param>
    public static bool GetYesOrNoConsoleInput(string message)
    {
        string stringInput = MyConsole.ReadLine(message);
        if (stringInput?.ToLower() == CHECKED_YES) // если ввод "y/Y" - продолжаем
        {
            return true;
        }
        else if (stringInput?.ToLower() == CHECKED_NO) // если ввод "n/N" - завершаем.
        {
            return false;
        }

        else // если введен другой символ/символы
        {
            return GetYesOrNoConsoleInput(NOT_CHOSEN_YES_OR_NO_MSG); // рекурсивный вызов ввода y или n
        }
    }
}
