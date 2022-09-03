using static MyLibrary.MyMethods;
public class Task15 : HomeworkTask
{
    public Task15() : base()
    {
        Number = 15; // номер задачи согласно списку ДЗ 
        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 
        
        Description = $"Выполняется задача №{Number}: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным."; 
        
        ShowMessage (Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
        Result = $" {Arguments[0]}  =>  ";
    }

    public override string Execute() //реализация задачи
    {
        if (Arguments[0]>7 || Arguments[0]<0)
            return Result+= "не является числовым представлением дня недели. Корректные числа для ввода - 1...7 ";

        int[] dayOff = {6,7};
        for (int i=0;i<dayOff.Length;i++)
            {
                
                if (dayOff[i]==Arguments[0])
                {
                    return Result +" да, это выходной";
                }
            }
         return Result + " нет, это не выходной";
    }
}