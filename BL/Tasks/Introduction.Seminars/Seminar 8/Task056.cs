using EKozlov.HomeWork.BL;
using System.Text;

public class Task056 : HomeworkTask
{
    public Task056() : base()
    {
        Number = 56;

        Description = $"\nВыполняется задача №{Number}:  Программа задаёт прямоугольный двумерный массив. " +
            $"\nи находит строку с наименьшей суммой элементов";
    }

    public override void Execute()
    {
        int rows = random.Next(2, 6);
        int columns = random.Next(2, 6);

        int[,] array = CreateInt2DimArray(rows, columns);

        Result = stringBuilder.ToString();
        stringBuilder.Clear();

        int minSumRow = 0;
        int sumLine = SumLineElements(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSumLine = SumLineElements(array, i);
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumRow = i;
            }
        }

        int SumLineElements(int[,] array, int i)
        {
            int sumLine = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                sumLine += array[i, j];
            }
            return sumLine;
        }

        Result+=($"\n{minSumRow + 1} - ряд с наименьшей суммой элементов ");
    }
}
