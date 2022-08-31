namespace MyLibrary; 

public static class MyConsole // обёртка для возможности записи в одну строку запроса на ввод(Write) и ReadLine 
{
    public static string ReadLine() => System.Console.ReadLine(); // возврат базового метода при отсутстии аргументов

    public static string ReadLine(string message) // перегрузка с аргументом, который необходимо вывести, как сообщение при помощи Write
    {
        System.Console.Write(message); 
        return ReadLine();
    }
}
