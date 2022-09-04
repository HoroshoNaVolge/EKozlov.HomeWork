using static MyLibrary.MyMethods;
public class Task4 : HomeworkTask
{
    public Task4() : base()
    {
        Number = 4; // номер задачи согласно списку ДЗ 
        QuantityOfArguments = 3; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход три числа и выдаёт максимальное из этих чисел.";

        ShowMessage(Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);

    }

    public override string Execute() //реализация задачи
    {
        int maxNumber = Arguments[0];
        for (int x = 0; x < Arguments.Length; x++)
            if (Arguments[x] > maxNumber) maxNumber = Arguments[x];

        return Result=$"Наибольшим числом из {Arguments[0]}, {Arguments[1]}, {Arguments[2]} является: " + (maxNumber);
    }
}