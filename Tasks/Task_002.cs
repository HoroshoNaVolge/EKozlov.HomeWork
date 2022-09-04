using static MyLibrary.MyMethods;
public class Task_002 : HomeworkTask
{
    public Task_002() : base()
    {
        Number = 2; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 2; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее."; // описание задачи

        ShowConsoleMessage(Description); // через делегат вывод в UI информации о выбранной задаче

        Arguments = CreateArgumentsForTask(QuantityOfArguments); // создание массива аргументов для данной задачи через ввод пользователем (метод родительского класса Homework) 
    }

    public override void Execute() //реализация задачи
    {
        int maxNumber = Arguments[0];
        int minNumber = Arguments[1];
        bool equalNumbers=false; // булева переменная, если введены два одинаковых числа

        if (Arguments[0] > Arguments[1])
        {
            maxNumber = Arguments[0];
            minNumber = Arguments[1];
        }
        else if (Arguments[0] < Arguments[1])
        {
            maxNumber = Arguments[1];
            minNumber = Arguments[0];
        }
        else  equalNumbers=true;
            // тернарная операция. Если equalNumbers==true, тогда присваиваем Result значение после '?', если equalNumbers==false, тогда присваеваем Result значение после ':'
            Result= equalNumbers? $"Числа одинаковы {Arguments[0]} и {Arguments[1]}" :  $"Наибольшим числом является: {maxNumber}. Наименьшим числом является: {minNumber}";
    }
}