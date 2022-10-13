using EKozlov.HomeWork.BL;
using System.Text;

public class Task058 : HomeworkTask
{
    public Task058() : base()
    {
        Number = 58;

        Description = $"\nВыполняется задача №{Number}:  Программа задаёт две матрицы. " +
                      $"и находит произведение двух матриц";
    }

    public override void Execute()
    {
        int rows = random.Next(2, 6);
        int columns = random.Next(2, 6);

        int[,] firstArray = CreateInt2DimArray(rows, columns);

        Console.WriteLine("\nПервая матрица:" + stringBuilder.ToString());
        stringBuilder.Clear();

        int[,] secondArray = CreateInt2DimArray(columns, columns);

        Console.WriteLine("\nВторая матрица:" + stringBuilder.ToString());
        stringBuilder.Clear();

        int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstArray.GetLength(1); k++)
                {
                    sum += firstArray[i, k] * secondArray[k, j];
                }
                resultArray[i, j] = sum;
            }
        }
      
        for (int i = 0; i < rows; i++)
        {
            stringBuilder.Append("\n");

            for (int j = 0; j < columns; j++)
            {
                stringBuilder.Append(resultArray[i, j] + " ");
            }
        }
        Result+="Таблица с перемноженными элементами:\n" + stringBuilder.ToString();

    }
}
