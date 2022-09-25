using EKozlov.HomeWork.BL;
using System.Text;

public class Task052 : HomeworkTask
{
    public Task052(bool noUserInputArgs) : base(noUserInputArgs)
    {
        Number = 52;

        Description = $"\nВыполняется задача №{Number}:  Программа задаёт двумерный массив из целых чисел " +
                      $"и находит среднее арифметическое элементов в каждом столбце.";
    }

    public override void Execute()
    {

        int rows = random.Next(2, 6);
        int columns = random.Next(2, 6);

        double[,] numbers = Create2DimArray(rows, columns);
        double[] sumByColumn = new double[columns];

        stringBuilder.Append($"Двухмерный массив размером {rows}x{columns}: \n" + stringBuilder.ToString() + "\n"
                             + "Среднее арифметическое каждого столбца: ");

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
                sumByColumn[i] += Math.Round((numbers[j, i]), 2);
        }

        foreach (double element in sumByColumn)
            stringBuilder.Append(Math.Round(element / columns, 2) + " ");

        Result = stringBuilder.ToString();
    }
}
