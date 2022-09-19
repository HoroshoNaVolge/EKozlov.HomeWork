using EKozlov.HomeWork.BL;

public class Task043 : HomeworkTask
{
    public Task043() : base()
    {
        Number = 43;
        QuantityOfArguments = 4;
        GroupedArguemnts = true;

        Description = $"\nВыполняется задача №{Number}:  Программа находит точку пересечения двух прямых, заданных уравнениями \n" +
            $"y = k1 * x + b1, y = k2 * x + b2; \nзначения b1, k1, b2 и k2 задаются пользователем.";
    }

    public override void Execute()
    {
        double k1 = Arguments[0];
        double b1 = Arguments[1];
        double k2 = Arguments[2];
        double b2 = Arguments[3];
        double x = 0;

        try { x = (b2 - b1) / (k1 - k2); }
        catch (DivideByZeroException) { }

        Result = !double.IsNaN(x)
                 ? $"Точка пересечения прямых => {Math.Round(x, 2)}; {Math.Round(k1 * x + b1, 2)}"
                 : $"k1({k1}) и k2({k2}) одинаковы, выполнение вызывает деление на ноль.";
    }
}