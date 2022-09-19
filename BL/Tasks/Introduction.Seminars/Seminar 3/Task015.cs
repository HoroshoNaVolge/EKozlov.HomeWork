using EKozlov.HomeWork.BL;

public class Task015 : HomeworkTask
{
    public Task015() : base()
    {
        Number = 15;

        QuantityOfArguments = 1;

        Description = $"\nВыполняется задача №{Number}: Программа принимает на вход цифру, обозначающую день недели, и проверяет, " +
                      $"является ли этот день выходным.";
    }

    public override void Execute()
    {
        if (Arguments[0] > 7 || Arguments[0] < 0)
            Result = $"{Arguments[0]} - число не является днём недели.";

        else
        {
            var dayOff = (saturday: 6, sunday: 7); 

            if (Arguments[0] == dayOff.saturday || Arguments[0] == dayOff.sunday) 
                Result = $" {Arguments[0]}  =>  " + " да, это выходной."; 

            else
                Result = $" {Arguments[0]}  =>  " + " нет, это не выходной.";
        }
    }
}