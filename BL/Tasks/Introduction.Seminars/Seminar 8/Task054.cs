using EKozlov.HomeWork.BL;
using System.Text;

public class Task054 : HomeworkTask
{
    public Task054() : base()
    {
        Number = 54;

        Description = $"\nВыполняется задача №{Number}:  Программа задаёт двумерный массив. " +
            $"и упорядочивает по убыванию элементы\nкаждой строки двумерного массива";
    }

    public override void Execute()
    {
        int rows = random.Next(2, 6);
        int columns = random.Next(2, 6);

        int[,] numbers = CreateInt2DimArray(rows, columns);

        Result = stringBuilder.ToString();
        stringBuilder.Clear();

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int k = 0; k < numbers.GetLength(1) - 1; k++)
                {
                    if (numbers[i, k] < numbers[i, k + 1])
                    {
                        int temp = numbers[i, k + 1];
                        numbers[i, k + 1] = numbers[i, k];
                        numbers[i, k] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            stringBuilder.Append("\n");
            for (int j = 0; j < numbers.GetLength(1); j++)
                stringBuilder.Append(numbers[i, j] + " ");

        }

        Result += "\nОтсортированный массив по убыванию каждой строки:\n" + stringBuilder.ToString();
    }
}
