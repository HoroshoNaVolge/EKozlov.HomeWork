using EKozlov.HomeWork.BL;

public class Task010 : HomeworkTask
{
    public Task010() : base()
    {
        Number = 10;

        QuantityOfArguments = 1;

        Description = $"\nВыполняется задача №{Number}: Программа принимает на вход трёхзначное число и на выходе показывает " +
                      $"вторую цифру этого числа.";
        
    }

    public override void Execute()
    {
        if ((Arguments[0] / 100 < 1 || Arguments[0] / 100 > 10)) 
            Result = $"{Arguments[0]} не трёхзначное число";

        else
        {
            int tempNumber = Arguments[0] / 10;

            int secondNumeral = tempNumber % 10; 

            Result = $"В трёхзначном числе {Arguments[0]}  вторая цифра => {secondNumeral}";
        }
    }
}