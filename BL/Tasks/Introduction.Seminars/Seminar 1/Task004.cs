using EKozlov.HomeWork.BL;

public class Task004 : HomeworkTask
{
    public Task004() : base()
    {
        Number = 4;

        QuantityOfArguments = 3;

        Description = $"\nВыполняется задача №{Number}: Программа принимает на вход три числа и выдаёт максимальное из этих чисел.";
    }

    public override void Execute()
    {
        int maxNumber = Arguments[0];
        for (int x = 0; x < Arguments.Length; x++)
            if (Arguments[x] > maxNumber) maxNumber = Arguments[x];

        Result = $"Наибольшим числом из {Arguments[0]}, {Arguments[1]}, {Arguments[2]} является: " + (maxNumber);
    }
}