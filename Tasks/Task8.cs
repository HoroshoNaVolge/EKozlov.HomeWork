using static MyLibrary.MyMethods;
public class Task8 : HomeworkTask
{
    public Task8() : base()
    {
        Number = 8; // номер задачи согласно списку ДЗ 
        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 
        
        Description = $"Выполняется задача №{Number}: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N."; 
        
        ShowMessage (Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
        Result = $"Список всех чётных чисел от 1 до {Arguments[0]}: ";
    }

    public override string Execute() //реализация задачи
    {
        int tempVar = Arguments[0];

        List<int> oddNumbers = new List<int>();

        for (int x = 1; x <= tempVar; x++)
        {
            if (x % 2 == 0)
                oddNumbers.Add(x);
        }
        foreach (int x in oddNumbers)
        {
            Result += x.ToString() + " ";
        }
        return Result;
    }
}