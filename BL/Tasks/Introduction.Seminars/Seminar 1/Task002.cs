using EKozlov.HomeWork.BL;

public class Task002 : HomeworkTask
{
    public Task002() : base()
    {
        Number = 2;

        QuantityOfArguments = 2;

        Description = $"\nВыполняется задача №{Number}: Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.";
    }

    public override void Execute()
    {
        int maxNumber = Arguments[0];

        int minNumber = Arguments[1];

        bool equalNumbers = false;

        if (Arguments[0] > Arguments[1])
        {
            maxNumber = Arguments[0];
            minNumber = Arguments[1];
        }
        else if (Arguments[0] < Arguments[1])
        {
            maxNumber = Arguments[1];
            minNumber = Arguments[0];
        }
        else equalNumbers = true;

        Result = equalNumbers ? $"Числа одинаковы {Arguments[0]} и {Arguments[1]}" : $"Наибольшим числом является: {maxNumber}. Наименьшим числом является: {minNumber}";
    }
}