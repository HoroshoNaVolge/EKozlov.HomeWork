using EKozlov.HomeWork.BL;
using System.ComponentModel.DataAnnotations;

public class Task_010 : HomeworkTask
{
    public Task_010() : base()
    {
        Number = 10; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа."; // описание задачи
        
    }

    public override void Execute() //реализация задачи
    {
        if ((Arguments[0] / 100 < 1 || Arguments[0] / 100 > 10)) // проверка, что число трёхзначное.
            Result = $"{Arguments[0]} не трёхзначное число";

        else
        {
            int tempNumber = Arguments[0] / 10; // 124 => 12 : получаем двукратное целое число без остатка.

            int secondNumeral = tempNumber % 10; //12 => 2 // берём остаток от деления на 10 - это ответ.

            Result = $"В трёхзначном числе {Arguments[0]}  вторая цифра => {secondNumeral}"; // присваиваем свойству Result результат выполнения метода Execute 
        }
    }
}