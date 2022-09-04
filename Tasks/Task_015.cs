using static MyLibrary.MyMethods;
public class Task_015 : HomeworkTask
{
    public Task_015() : base()
    {
        Number = 15; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.";

        ShowMessage(Description);

        Arguments = CreateArgumentsForTask(QuantityOfArguments);
    }

    public override void Execute() //реализация задачи
    {
        // TODO заменить на валидацию модели
        while (Arguments[0] > 7 || Arguments[0] < 0)
            Arguments[0] = GetConsoleInput($" {Arguments[0]} не является числовым представлением дня недели.Корректные числа для ввода - 1...7.\nПовторите ввод: ");

        int[] dayOff = { 6, 7 };

        if (Arguments[0] == dayOff[0] || Arguments[0] == dayOff[1])
            Result = $" {Arguments[0]}  =>  " + " да, это выходной";
        else
            Result = $" {Arguments[0]}  =>  " + " нет, это не выходной";
    }
}