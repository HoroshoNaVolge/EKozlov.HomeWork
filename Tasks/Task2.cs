using static MyLibrary.MyMethods;
public class Task2 : HomeworkTask
{
    public Task2() : base()
    {
        Number = 2;
        QuantityOfArguments = 2;
        Description = $"Выполняется задача №{Number}: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.";
        
        ShowMessage(Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
        Result = "Наибольшим числом является: ";
    }

    public override string Execute()
    {


        int maxNumber = Arguments[0];
        int minNumber = Arguments[1];

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
        else
            return $"Числа одинаковы {Arguments[0]} и {Arguments[1]}";

        return Result + (maxNumber) + ". Наименьшим числом является " + minNumber;
    }
}