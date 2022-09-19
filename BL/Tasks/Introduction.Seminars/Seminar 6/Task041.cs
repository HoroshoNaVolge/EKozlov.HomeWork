using EKozlov.HomeWork.BL;

public class Task041 : HomeworkTask
{
    public Task041() : base()
    {
        Number = 41;
        QuantityOfArguments = new Random().Next(3, 10);

        Description = $"\nВыполняется задача №{Number}: Пользователь вводит с клавиатуры M \n(рандомно - {QuantityOfArguments}) чисел.\n" +
                      $"Программа считает сколько чисел больше нуля ввёл пользователь.";
    }

    public override void Execute()
    {
        Result = "Введены числа: " + GetSequenceInText(Arguments) + 
                 ". Количество чисел больше нуля => " +
                 (from a in Arguments where a > 0 select a).Count().ToString();
    }
}