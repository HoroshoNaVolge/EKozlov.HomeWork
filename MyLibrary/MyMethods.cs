namespace MyLibrary;
public static class MyMethods
{
    public static void ShowMessage(string msg) => Console.WriteLine(msg); // Метод вывода сообщений вызывает Консоль. Возможна замена в дальнейшем на другой UI.

    public static int GetConsoleInput(string message) //переопределен метод Readline() для дополнительной логики и возможности выполнить сразу с методом Write
    {
        string consoleInput = MyConsole.ReadLine(message); //  Кладём в переменную вводенные данные с консоли

        if (int.TryParse(consoleInput, out var parseResult)) // Проверка на допустимость преобразования введенных символов в тип int.  
            return parseResult; // true - Возвращаем запарсенный int 
        else
            return GetConsoleInput(Message.incorrect_input_msg); // false - рекурсивно вызываем метод ввода, пока не будет корректного ввода

        //TODO: добавить выход из программы при нажатии ESC 
    }
}