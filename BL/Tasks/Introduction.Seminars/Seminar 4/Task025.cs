using EKozlov.HomeWork.BL;

public class Task025 : HomeworkTask
{
    public Task025() : base()
    {
        Number = 25;

        QuantityOfArguments = 2; 

        Description = $"\nВыполняется задача №{Number}: Цикл принимает на вход два числа (A и B) и возводит число A в натуральную степень B.";
    }

    public override void Execute() => Result = $"Первое число: {Arguments[0]}\nВторое число: {Arguments[1]}\nПервое число в натуральной степени второго числа = {Math.Pow(Arguments[0], Arguments[1])}.";

    // Цикл ввода аргументов уже реализован через делегат ввода из UI в методе CreateArgumentsForTask() класса TaskExecutor (работает для всех заданий).
}