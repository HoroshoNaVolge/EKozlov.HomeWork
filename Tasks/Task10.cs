using static MyLibrary.MyMethods;
public class Task10 : HomeworkTask
{
    public Task10() : base()
    {
        Number = 10; // номер задачи согласно списку ДЗ 
        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 
        
        Description = $"Выполняется задача №{Number}: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа."; 
        
        ShowMessage (Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
        Result = $" Трёхзначное число {Arguments[0]} без второй цифры => ";
    }

    public override string Execute() //реализация задачи
    {
        if (Arguments[0]/100<1||Arguments[0]/100>10)
        {
            return "Введено не трёхзначное число. Работа завершена.";
        }

        int a1=Arguments[0]%10; // 124 =? 4
        int a2= Arguments[0]/100; //124> 1

        return Result + (a2*10 +a1);
    }
}