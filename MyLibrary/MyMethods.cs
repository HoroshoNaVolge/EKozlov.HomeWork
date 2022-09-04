namespace MyLibrary;
using static Message;

public static class MyMethods // стат. класс для моими методами
{
    public delegate void MessageHandler(string msg);
    public static void ConsoleMessage(string msg) => Console.WriteLine(msg); // Метод вывода сообщений вызывает Консоль. Возможна замена в дальнейшем на другой UI.

    public static int GetConsoleInput(string message) //переопределен метод Console.Readline() для дополнительной логики и возможности выполнить сразу с методом Write
    {
        string? consoleInput = MyConsole.ReadLine(message); //  Кладём в переменную вводенные данные с консоли. Используем MyConsole для возможности одновременно использовать Console. Write

        if (int.TryParse(consoleInput, out var parseResult)) // Проверка на допустимость преобразования введенных символов в тип int.  
            return parseResult; // преобразование возможно - возвращаем int 
        else
            return GetConsoleInput(incorrect_input_msg); // преобразование невозможно - рекурсивно вызываем метод ввода, пока не будет корректного ввода
    }

    public static bool GetYesOrNoInput(string message) // метод получания ввода "y" (т.е. true) или "n" (т.е. false) с проверкой и рекурсией при некорректном вводе "y" или "n"
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
            return GetYesOrNoInput(not_chosen_yes_or_no_msg); // рекурсивный вызов ввода y или n
        }
    }
}
