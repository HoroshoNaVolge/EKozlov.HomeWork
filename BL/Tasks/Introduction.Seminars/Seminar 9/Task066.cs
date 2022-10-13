using EKozlov.HomeWork.BL;
using System.Text;

public class Task066 : HomeworkTask
{
    public Task066() : base()
    {
        Number = 66;

        QuantityOfArguments = 2;

        SpecifiedArgumentsNames = new string[] { "M", "N" };

        Description = $"\nВыполняется задача №{Number}: Программа находит сумму натуральных элементов в промежутке от M до N. ";
    }

    public override void Execute()
    {
        int sum = 0;

        for (int i = Arguments[0]; i <= Arguments[1]; i++)
            sum += i;
   
        Result = $"Сумма элементов от {Arguments[0]} до {Arguments[1]} = {sum}";
    }
}
