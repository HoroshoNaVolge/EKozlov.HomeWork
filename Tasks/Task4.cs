public class Task4 : HomeworkTask
{
    public Task4() : base()
    {
        Number = 4;
        QuantityOfArguments = 3;
        Result = $"Наибольшим числом из {Arguments[0]}, {Arguments[1]}, {Arguments[2]} является: ";
        Description = $"Выполняется задача №{Number}: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.";
        Console.WriteLine(Description);
        Arguments = CreateArgumentsForTask(QuantityOfArguments);
    }

    public override string ExecuteTask()
    {
        int maxNumber=Arguments[0];
        for (int x=0; x<Arguments.Length; x++)
            if (Arguments[x]>maxNumber) maxNumber=Arguments[x];

        return Result + (maxNumber);
    }
}