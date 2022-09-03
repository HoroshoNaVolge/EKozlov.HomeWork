namespace MyLibrary;
using static Message;

public static class MyMethods // стат. класс для моими методами
{
    public static void ShowMessage(string msg) => Console.WriteLine(msg); // Метод вывода сообщений вызывает Консоль. Возможна замена в дальнейшем на другой UI.

    public static int GetConsoleInput(string message) //переопределен метод Console.Readline() для дополнительной логики и возможности выполнить сразу с методом Write
    {
        string consoleInput = MyConsole.ReadLine(message); //  Кладём в переменную вводенные данные с консоли. Используем MyConsole для возможности одновременно использовать Console. Write

        if (int.TryParse(consoleInput, out var parseResult)) // Проверка на допустимость преобразования введенных символов в тип int.  
            return parseResult; // преобразование возможно - возвращаем int 
        else
            return GetConsoleInput(incorrect_input_msg); // преобразование невозможно - рекурсивно вызываем метод ввода, пока не будет корректного ввода
    }
}