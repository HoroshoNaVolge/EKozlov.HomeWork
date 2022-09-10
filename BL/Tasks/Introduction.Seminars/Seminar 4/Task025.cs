using EKozlov.HomeWork.BL;

public class Task025 : HomeworkTask
{
    public Task025() : base()
    {
        Number = 25; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 2; // количество аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Цикл принимает на вход два числа (A и B) и возводит число A в натуральную степень B.";
    }

    public override void Execute() //реализация задачи
    {
        // Цикл ввода аргументов уже реализован в методе CreateArgumentsForTask() класса TaskExecutor.

        Result = $"Первое число: {Arguments[0]}\nВторое число: {Arguments[1]}\nПервое число в натуральной степени второго числа = {Math.Pow(Arguments[0],Arguments[1])}.";
    }
}