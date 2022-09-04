using static MyLibrary.MyMethods;
public class Task_006 : HomeworkTask
{
    public Task_006() : base()
    {
        Number = 6; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)"; // описание задачи

        ShowConsoleMessage(Description); // вывод в UI информации о выбранной задаче

        Arguments = CreateArgumentsForTask(QuantityOfArguments); // создание массива аргументов для данной задачи через ввод пользователем (метод родительского класса Homework) 
    }

    public override void Execute() //реализация задачи
    {
        int checkNumberAsOdd = Arguments[0];
        if (checkNumberAsOdd % 2 == 0)
            Result = "Число " + checkNumberAsOdd + " является чётным.";
        else
            Result = "Число " + checkNumberAsOdd + " НЕ является чётным.";
    }
}