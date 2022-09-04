using static MyLibrary.MyMethods;
public class Task_010 : HomeworkTask
{
    public Task_010() : base()
    {
        Number = 10; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.";

        ShowMessage(Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
    }

    public override void Execute() //реализация задачи
    {   // TODO ПЕРЕПИСАТЬ НА ВАЛИДАЦИЮ МОДЕЛИ
        if (Arguments[0] / 100 < 1 || Arguments[0] / 100 > 10)
        {

            Result = "Введено не трёхзначное число. Работа завершена.";
        }
        //TODO ДОБАВИТЬ РЕКУРСИЮ НА ЗАПРОС ВВОДА ПРИ ВВОДЕ НЕТРЕХЗНАЧНОГО ЧИСЛА
        int tempNumber = Arguments[0] / 10; // 124 => 12 : получаем двукратное целое число без остатка
        int secondNumeral = tempNumber % 10; //12 => 2 // берём остаток от деления на 10 - это ответ.

        Result = $"В трёхзначном числе {Arguments[0]}  вторая цифра => {secondNumeral}";

    }
}