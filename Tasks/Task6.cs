using static MyLibrary.MyMethods;
public class Task6 : HomeworkTask
{
    public Task6() : base()
    {
        Number = 6;
        QuantityOfArguments = 1;
        
        Description = $"Выполняется задача №{Number}: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)";
        
        ShowMessage (Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);

        Result = "Число ";
    }

    public override string Execute()
    {
        int checkNumberAsOdd = Arguments[0];
        if (checkNumberAsOdd % 2 == 0)
            return Result + checkNumberAsOdd + " является чётным.";
        else
            return Result + checkNumberAsOdd + " НЕ является чётным.";
    }
}