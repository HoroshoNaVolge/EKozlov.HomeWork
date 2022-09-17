using EKozlov.HomeWork.BL;

public class Task043 : HomeworkTask
{
    public Task043() : base()
    {
        Number = 43; // номер задачи согласно списку ДЗ 
        QuantityOfArguments = 4;
        GroupedArguemnts = true;

        Description = $"Выполняется задача №{Number}:  Программа находит точку пересечения двух прямых, заданных уравнениями \n" +
            $"y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.";

    }

    public override void Execute() //реализация задачи
    {
        double k1 = Arguments[0];
        double b1 = Arguments[1];
        double k2 = Arguments[2];
        double b2 = Arguments[3];
        double x;

        //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

        try { x = (b2 - b1) / (k1 - k2); }
        catch (DivideByZeroException) {}

        Result = x is not double.NaN ? $"Точка пересечения прямых => {Math.Round(x, 2)}; {Math.Round((k1 * x + b1), 2)}" : "k1 и k2 одинаковы. Деление на ноль невозможно.";

    }
}