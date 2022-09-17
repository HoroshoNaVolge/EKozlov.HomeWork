using EKozlov.HomeWork.BL;

public class Task041 : HomeworkTask
{
    public Task041() : base()
    {
        Number = 41; // номер задачи согласно списку ДЗ 
        QuantityOfArguments = new Random().Next(3, 10);

        Description = $"Выполняется задача №{Number}: Пользователь вводит с клавиатуры M (рандомно - {QuantityOfArguments}) чисел.\nПосчитайте, сколько чисел больше нуля ввёл пользователь.";
    }

    public override void Execute() //реализация задачи
    {
        Result = "Введены числа: " + GetSequenceInText(Arguments) + ". Количество чисел больше нуля => " +
            (from a in Arguments where a > 0 select a).Count().ToString();
    }
}