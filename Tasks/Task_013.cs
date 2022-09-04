using static MyLibrary.MyMethods;
public class Task_013 : HomeworkTask
{
    public Task_013() : base()
    {
        Number = 13; // номер задачи согласно списку ДЗ 
        
        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.";

        ShowMessage(Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
    }

    public override void Execute() //реализация задачи
    {
        string tempStringNumber = Arguments[0].ToString();
        char[] charNumberInString = tempStringNumber.ToCharArray();
        if (charNumberInString.Length >= 3)
            Result = $"Третья цифра числа {Arguments[0]}  => " + Result + tempStringNumber[2];
        else
            Result = "Третьей цифры нет";
    }
}