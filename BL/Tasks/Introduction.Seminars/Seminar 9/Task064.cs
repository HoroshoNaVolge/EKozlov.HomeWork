using EKozlov.HomeWork.BL;
using System.Text;

public class Task064 : HomeworkTask
{
    public Task064() : base()
    {
        Number = 64;

        QuantityOfArguments = 1;

        SpecifiedArgumentsNames = new string[] { "N" };

        Description = $"\nВыполняется задача №{Number}: Программу выводит все чётные числа в промежутке от N до 1. Выполниется с помощью рекурсии.";

    }

    public override void Execute() => Result = GetEvenAsText(Arguments[0]);

    private string GetEvenAsText(int number)
    {
        if (number == 2)
            return number.ToString();

        return number % 2 == 0 ? number.ToString() + ", " + GetEvenAsText(number - 1) : GetEvenAsText(number - 1);
    }
}
