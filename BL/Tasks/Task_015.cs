using EKozlov.HomeWork.BL;
using static EKozlov.HomeWork.View.Console_UI;

public class Task_015 : HomeworkTask
{
    public Task_015() : base()
    {
        Number = 15; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.";
    }

    public override void Execute() //реализация задачи
    {
        if (Arguments[0] > 7 || Arguments[0] < 0) // проверка числа на нахождение в диапазоне от 1 до 7 вкл.
            Result = $"{Arguments[0]} - число не является днём недели.";

        else
        {
            var dayOff = (saturday: 6, sunday: 7); // Используем кортеж c именами для элементов. Выходные дни по условиям задачи: 6 (суббота) и 7 (воскресенье) 

            if (Arguments[0] == dayOff.saturday || Arguments[0] == dayOff.sunday) // проверка на равенство аргумента либо 6 либо 7. Для оптимизации используем || - проверяет первый блок - если true, второй уже не выполняется (в отиличии от |).
                Result = $" {Arguments[0]}  =>  " + " да, это выходной."; // если true, то присваиваем свойству Result результат выполнения метода Execute

            else
                Result = $" {Arguments[0]}  =>  " + " нет, это не выходной."; // если false, то также присваиваем свойству Result результат выполнения метода Execute
        }

    }
}