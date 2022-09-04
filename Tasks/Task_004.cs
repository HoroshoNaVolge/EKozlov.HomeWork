using static MyLibrary.MyMethods;
public class Task_004 : HomeworkTask
{
    public Task_004() : base()
    {
        Number = 4; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 3; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход три числа и выдаёт максимальное из этих чисел."; // описание задачи

        ShowMessage(Description); // вывод в UI информации о выбранной задаче

        Arguments = CreateArgumentsForTask(QuantityOfArguments); // создание массива аргументов для данной задачи через ввод пользователем (метод родительского класса Homework) 
    }

    public override void Execute() //реализация задачи
    {
        int maxNumber = Arguments[0];
        for (int x = 0; x < Arguments.Length; x++)
            if (Arguments[x] > maxNumber) maxNumber = Arguments[x];

        Result = $"Наибольшим числом из {Arguments[0]}, {Arguments[1]}, {Arguments[2]} является: " + (maxNumber);
    }
}