public class Task8 : HomeworkTask
{
    public Task8() : base()
    {
        Number = 2;
        QuantityOfArguments = 1;
        Result = $"Список всех чётным чиселн от 1 до {Arguments[0]}";
        Description = $"Выполняется задача №{Number}: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N."; 
        Console.WriteLine(Description);
        Arguments = CreateArgumentsForTask(QuantityOfArguments);
    }

    public override string ExecuteTask()
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