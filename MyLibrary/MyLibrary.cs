// Моя библиотека для проекта ДЗ.

namespace MyLibrary;

#region Стат. класс с оберткой для консоли
public static class MyConsole // обёртка для возможности записи в одну строку запроса на ввод(Write) и ReadLine 
{
    public static string ReadLine() => System.Console.ReadLine(); // возврат базового метода при отсутстии аргументов

    public static string ReadLine(string message) // перегрузка с аргументом, который необходимо вывести как сообщение при помощи Write
    {
        System.Console.Write(message);
        return ReadLine();
    }
}
#endregion

#region Стат. класс с пределенными текстовыми сообщениями для консоли
public static class Message // статичные переменные с текстом сообщений для вывода в UI
{
    public static string incorrect_input_msg= "Некорректный ввод. Повторите попытку ввода целого числа: " ;

    public static string invite_to_input_number_msg = "Введите целое число: ";

    public static string invite_to_input_hometask_number_msg = "Введите номер задачи: ";

    public static string not_implemented_task_number = "Непредусмотренный номер задачи. Перезапустите программу.";
}
#endregion

#region Стат. класс с моими методами
public static class MyMethods
{ 
    public static string GetConsoleInput() => MyConsole.ReadLine(); // обертка для Console.Readline (); 
    public static int GetConsoleInput(string message) //переопределен метод Readline() для возможности записи в одну строку и дополнительной логики
    { 
        
        string consoleInput = MyConsole.ReadLine(message); //  Кладём в переменную вводенные данные с консоли
        
        if (int.TryParse(consoleInput, out var parseResult)) // Проверка на допустимость преобразования введенных символов в тип int.  
            return parseResult; // true - Возвращаем запарсенный int 
        else 
            return GetConsoleInput(Message.incorrect_input_msg); // false - рекурсивно вызываем метод ввода, пока не будет корректного ввода
        
        //TODO: добавить выход из программы при нажатии ESC 
    }
}
 #endregion