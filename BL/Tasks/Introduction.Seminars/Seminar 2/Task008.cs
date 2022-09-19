using EKozlov.HomeWork.BL;

public class Task008 : HomeworkTask
{
    public Task008() : base()
    {
        Number = 8;

        QuantityOfArguments = 1;

        Description = $"\nВыполняется задача №{Number}: Программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.";
    }

    public override void Execute()
    {
        int tempVar = Arguments[0]; 

        List<int> evenNumbers = new List<int>();

        for (int x = 1; x <= tempVar; x++)
        {
            if (x % 2 == 0)
                evenNumbers.Add(x);
        }

        string listOfOdds = string.Empty;

        foreach (int x in evenNumbers)  
        {
            listOfOdds += x.ToString() + " ";
        }

        Result = $"Список всех чётных чисел от 1 до {Arguments[0]}: " + listOfOdds;
    }
}