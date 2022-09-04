using static MyLibrary.MyMethods;
using System.ComponentModel.DataAnnotations;
public class Task_010 : HomeworkTask
{
    public Task_010() : base()
    {
        Number = 10; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа."; // описание задачи

        ShowConsoleMessage(Description); // вывод в UI информации о выбранной задаче

        Arguments = CreateArgumentsForTask(QuantityOfArguments); // создание массива аргументов для данной задачи через ввод пользователем (метод родительского класса Homework) 
    }

    public override void Execute() //реализация задачи
    {
        // TODO ПЕРЕПИСАТЬ НА ВАЛИДАЦИЮ МОДЕЛИ
        while ((Arguments[0] / 100 < 1 || Arguments[0] / 100 > 10)) // проверка, что число трёхзначное.
            Arguments[0] = GetConsoleInput("Введено не трёхзначное число. Повторите ввод: ");

        int tempNumber = Arguments[0] / 10; // 124 => 12 : получаем двукратное целое число без остатка.

        int secondNumeral = tempNumber % 10; //12 => 2 // берём остаток от деления на 10 - это ответ.

        Result = $"В трёхзначном числе {Arguments[0]}  вторая цифра => {secondNumeral}"; // присваиваем свойству Result результат выполнения метода Execute 
    }
}