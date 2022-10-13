using EKozlov.HomeWork.BL;
using System.Text;

public class Task062 : HomeworkTask
{
    public Task062() : base()
    {
        Number = 62;

        Description = $"\nВыполняется задача №{Number}:  Программа, которая заполнит спирально массив 4 на 4";
    }

    public override void Execute()
    {
        int[,] squareArray = CreateInt2DimArray(4, 4);
        stringBuilder.Clear();

        int temp = 1;
        int i = 0;
        int j = 0;

        while (temp <= squareArray.GetLength(0) * squareArray.GetLength(1))
        {
            squareArray[i, j] = temp;
            temp++;
            if (i <= j + 1 && i + j < squareArray.GetLength(1) - 1)
                j++;
            else if (i < j && i + j >= squareArray.GetLength(0) - 1)
                i++;
            else if (i >= j && i + j > squareArray.GetLength(1) - 1)
                j--;
            else
                i--;
        }

        for (int k = 0; k < squareArray.GetLength(0); k++)
        {
            for (int z = 0; z < squareArray.GetLength(1); z++)
            {
                if (squareArray[k, z] / 10 <= 0)
                    stringBuilder.Append($" {squareArray[k, z]} ");

                else stringBuilder.Append($"{squareArray[k, z]} ");
            }
            stringBuilder.Append("\n");
        }

        Result = stringBuilder.ToString();
    }
}
