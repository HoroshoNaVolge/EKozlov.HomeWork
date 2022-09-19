using EKozlov.HomeWork.BL;

public class Task029 : HomeworkTask
{
    public Task029() : base()
    {
        Number = 29;

        QuantityOfArguments = 8;

        Description = $"\nВыполняется задача №{Number}: Программа задаёт массив из 8 элементов и выводит их на экран. ";
    }

    public override void Execute()
    {
        // Массив элементов уже задан и присвоен свойству int[] Arguments в методе CreateArgumentsForTask класса TaskExecutor.  
        // Здесь работаем уже со свойством.

        for (int i = 0; i < Arguments.Length; i++)
            Result += i != Arguments.Length - 1 ? Arguments[i] + ", " : Arguments[i];

        Result = $"Результат: [{Result}]";
    }
}