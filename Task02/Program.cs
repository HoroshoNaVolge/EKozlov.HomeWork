/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

public class Program
{
    private static void Main(string[] args)
    {
        int n1, n2; // объявляем переменные для 

        string stringInput = MyConsole.ReadLine(Message.intiveToInputNumberMessage); // записываем результат ввода в переменную string

        if (InputChecker(stringInput))
            n1 = int.Parse(stringInput);
        else stringInput = MyConsole.ReadLine(Message.incorrectInputMessage);
    }

    public static bool InputChecker(string consoleInput)
    {
        var tempString = consoleInput;
        if (int.TryParse(tempString, out var x))
            return true;
        return false;

    }
}

#region Обёрта для Console.ReadLine();
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
    public static string incorrectInputMessage = "Некорректный ввод. Повторите попытку в соответствии с условием";
    public static string intiveToInputNumberMessage = "Введите целое число: ";
}
#endregion
