using static MyLibrary.MyMethods;
public class Task13 : HomeworkTask
{
    public Task13() : base()
    {
        Number = 13; // номер задачи согласно списку ДЗ 
        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 
        
        Description = $"Выполняется задача №{Number}: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет."; 
        
        ShowMessage (Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
    
    }

    public override string Execute() //реализация задачи
    {
        string tempStringNumber = Arguments[0].ToString();
        char[] charNumberInString = tempStringNumber.ToCharArray();
        if (charNumberInString.Length>=3)
            return $"Третья цифра числа {Arguments[0]}  => " + Result+tempStringNumber[2];
        else
            return "Третьей цифры нет";

    }
}