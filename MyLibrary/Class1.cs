namespace MyLibrary;
#region Класс с оберткой для консоли;
public static class MyConsole // обёртка для возможности записи в одну строку запроса на ввод(WriteLine) и ReadLine 
{
    public static string ReadLine() => System.Console.ReadLine(); // возврат базового метода при отсутстии аргументов

    public static string ReadLine(string message) // перегрузка с аргументом, который необходимо вывести при помощи WriteLine
    {
        System.Console.WriteLine(message);
        return ReadLine();
    }
}
#endregion

#region Отделенные строки вывода в консоль
public static class Message
{
    public static string incorrectInputMessage = "Некорректный ввод. Повторите попытку ввода целого числа: " ;
    public static string inviteToInputNumberMessage = "Введите целое число: ";
}
#endregion
