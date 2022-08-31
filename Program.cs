using MyLibrary;
public class Program
{
    private static void Main(string[] args)
    {
        int n1, n2; // объявляем переменные для 
        
        string stringInput = MyMethods.GetConsoleInput(Message.inviteToInputNumberMessage); // записываем результат ввода в переменную string

        while (!MyMethods.ConsoleInputChecker(stringInput))
            stringInput = MyMethods.GetConsoleInput(Message.incorrectInputMessage);
        
        n1 = int.Parse(stringInput);

        stringInput = MyMethods.GetConsoleInput(); // записываем результат ввода в переменную string

        while (!MyMethods.ConsoleInputChecker(stringInput))
            stringInput = MyMethods.GetConsoleInput(Message.incorrectInputMessage);
        
        n2 = int.Parse(stringInput);

        int maxNumber = n1>n2?n1:n2;
        Console.WriteLine($"Из двух чисел {n1} и {n2} наибольшим является {maxNumber}");
        
    }

}

#region Класс с моими методами
public static class MyMethods{ 
    public static string GetConsoleInput() => MyConsole.ReadLine(); // обертка для Console.Readline (); 
    public static string GetConsoleInput(string message) => MyConsole.ReadLine(message); //переопределен метод Readline() для возможности записи в одну строку запроса на ввод(WriteLine) и ReadLine 
    public static bool ConsoleInputChecker(string consoleInput) // выделенная в отдельный метод проверка ввода из консоли на возможность преобразования в инт
    {
        var tempString = consoleInput; // работаем через дополнительную переменную, а не напрямую с аргументом
        
        return int.TryParse(tempString, out var x) ? true: false; // преобразование в int возможно - возвращаем true, иначе false;
    }
}
 #endregion
