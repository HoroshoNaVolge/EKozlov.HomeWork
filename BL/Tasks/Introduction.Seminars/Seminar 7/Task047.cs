using EKozlov.HomeWork.BL;
using System.Text;

public class Task047 : HomeworkTask
{
    public Task047() : base()
    {
        Number = 47;

        Description = $"\nВыполняется задача №{Number}:  Программа задаёт двумерный массив размером m*n, " +
                      $"\nзаполненный случайными вещественными числами\n";
    }

    public override void Execute()
    {
        // Ограничим m (rows) и n (columns) для улучшения читабельности.

        int rows = random.Next(2, 6);
        int columns = random.Next(2, 6);

        CreateInt2DimArray(rows, columns);

        Result = $"Двухмерный массив размером {rows}x{columns}: \n" + stringBuilder.ToString() + "\n";
    }
}