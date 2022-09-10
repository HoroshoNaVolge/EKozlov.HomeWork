using EKozlov.HomeWork.BL;

public class Task029 : HomeworkTask
{
    public Task029() : base()
    {
        Number = 29; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 8; // количество аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа задаёт массив из 8 элементов и выводит их на экран. ";
    }

    public override void Execute() //реализация задачи
    {
        // Массив элементов уже задан и присвоен свойству int[] Arguments - заполняется вводом пользователя в методе CreateArgumentsForTask класса TaskExecutor.  
        // Здесь работаем уже со свойством.

        for (int i = 0; i < Arguments.Length; i++)
            Result += i != Arguments.Length - 1 ? Arguments[i] + ", " : Arguments[i];

        Result = $"Результат: [{Result}]";
    }
}