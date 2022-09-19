using EKozlov.HomeWork.BL;

public class Task043 : HomeworkTask
{
    public Task043() : base()
    {
        Number = 43;

        SpecifiedArgumentsNames = new string[] { "b1", "k1", "b2", "k2" };

        Description = $"\nВыполняется задача №{Number}:  Программа находит точку пересечения двух прямых, заданных уравнениями \n" +
            $"y = k1 * x + b1, y = k2 * x + b2; \nЗначения b1, k1, b2 и k2 задаются пользователем.";
    }

    public override void Execute()
    {
        // Копируем значения в переменные для улучшения читаемости.

        double b1 = Arguments[0];
        double k1 = Arguments[1];
        double b2 = Arguments[2];
        double k2 = Arguments[3];

        double x = (b2 - b1) / (k1 - k2);

        Result = double.IsFinite(x)
                 ? $"Точка пересечения прямых => {Math.Round(x, 2)}; {Math.Round(k1 * x + b1, 2)}"
                 : $"Прямые не пересекаются.";
    }
}