using EKozlov.HomeWork.BL;

public class Task006 : HomeworkTask
{
    public Task006() : base()
    {
        Number = 6;

        QuantityOfArguments = 1;

        Description = $"\nВыполняется задача №{Number}: Программа на вход принимает число и выдаёт, является ли число чётным " +
                      $"(делится ли оно на два без остатка)";
    }

    public override void Execute()
    {
        int checkNumberAsOdd = Arguments[0];

        if (checkNumberAsOdd % 2 == 0)
            Result = "Число " + checkNumberAsOdd + " является чётным.";
        else
            Result = "Число " + checkNumberAsOdd + " НЕ является чётным.";
    }
}