using static MyLibrary.MyMethods;
public class Task_002 : HomeworkTask
{
    public Task_002() : base()
    {
        Number = 2; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 2; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.";

        ShowMessage(Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
    }

    public override void Execute() //реализация задачи
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
            Result = $"Числа одинаковы {Arguments[0]} и {Arguments[1]}";

        Result = $"Наибольшим числом является: {maxNumber}. Наименьшим числом является: {minNumber}";
    }
}