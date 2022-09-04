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
        if (Arguments[0] > 7 || Arguments[0] < 0)
            Result = Arguments[0] + " не является числовым представлением дня недели.\nКорректные числа для ввода - 1...7 ";

        int[] dayOff = { 6, 7 };
        for (int i = 0; i < dayOff.Length; i++)
        {
            if (dayOff[i] == Arguments[0])
            {
                Result = $" {Arguments[0]}  =>  " + " да, это выходной";
            }
            else Result = $" {Arguments[0]}  =>  " + " нет, это не выходной";
        }
    }
}