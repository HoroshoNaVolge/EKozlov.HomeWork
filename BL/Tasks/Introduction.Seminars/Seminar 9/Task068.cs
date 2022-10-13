using EKozlov.HomeWork.BL;
using System.Text;

public class Task068 : HomeworkTask
{
    public Task068() : base()
    {
        Number = 68;

        Description = $"\nВыполняется задача №{Number}:  Напишите программу вычисления функции Аккермана с помощью рекурсии." +
                      $"\nДаны два неотрицательных числа m и n.";
    }

    public override void Execute()
    {
        int m = random.Next(2, 4);
        int n = random.Next(2, 4);

        Result = $"Числа {m} и {n}. Результат: {AkkermanFunc(m,n)}";
    }

    private int AkkermanFunc(int m, int n)
    {
        if (m == 0)
            return n + 1;

        if (m > 0 && n == 0)
            return AkkermanFunc(m - 1, 1);

        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }
}
