using static MyLibrary.MyMethods;
public class Task13 : HomeworkTask
{
    public Task13() : base()
    {
        Number = 13; // номер задачи согласно списку ДЗ 
        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 
        
        Description = $"Выполняется задача №{Number}: Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет."; 
        
        ShowMessage (Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
    
    }

    public override string Execute() //реализация задачи
    {
        string tempStringNumber = Arguments[0].ToString();
        char[] charNumberInString = tempStringNumber.ToCharArray();
        if (charNumberInString.Length>=3)
            return Result=$"Третья цифра числа {Arguments[0]}  => " + Result+tempStringNumber[2];
        else
            return Result="Третьей цифры нет";

    }
}