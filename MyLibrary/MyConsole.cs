namespace MyLibrary; 

public static class MyConsole // обёртка для возможности записи в одну строку запроса на ввод(Write) и ReadLine 
{
    public static string? ReadLine(string message) // перегрузка с аргументом, который необходимо вывести, как сообщение при помощи Write. Допускаем NULL при помощи <string?>
    {
        System.Console.Write(message); 
        return System.Console.ReadLine();
    }
}
