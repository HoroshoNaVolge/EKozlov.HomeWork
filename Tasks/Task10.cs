using static MyLibrary.MyMethods;
public class Task10 : HomeworkTask
{
    public Task10() : base()
    {
        Number = 10; // номер задачи согласно списку ДЗ 
        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 
        
        Description = $"Выполняется задача №{Number}: Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа."; 
        
        ShowMessage (Description);
      
        Arguments = CreateArgumentsForTask(QuantityOfArguments);        
    }

    public override string Execute() //реализация задачи
    {   // TODO ПЕРЕПИСАТЬ НА ВАЛИДАЦИЮ МОДЕЛИ
        if (Arguments[0]/100<1||Arguments[0]/100>10)
        {
            return "Введено не трёхзначное число. Работа завершена.";
        }
        //TODO ДОБАВИТЬ РЕКУРСИЮ НА ЗАПРОС ВВОДА ПРИ ВВОДЕ НЕТРЕХЗНАЧНОГО ЧИСЛА
        int tempNumber=Arguments[0]/10; // 124 => 12 : получаем двукратное целое число без остатка
        int secondNumeral= tempNumber%10; //12 => 2 // берём остаток от деления на 10 - это ответ.

        return $"В трёхзначном числе {Arguments[0]}  вторая цифра => {secondNumeral}";

    }
}