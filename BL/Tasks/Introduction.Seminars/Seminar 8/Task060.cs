using EKozlov.HomeWork.BL;
using System.Text;

public class Task060 : HomeworkTask
{
    public Task060() : base()
    {
        Number = 60;

        Description = $"\nВыполняется задача №{Number}:  Программа формирует трёхмерный массив из неповторяющихся двузначных чисел. " +
                      $"и построчно выводит массив, добавляя индексы каждого элемента";
    }

    public override void Execute()
    {
        int xD = random.Next(2, 5);
        int yD = random.Next(2, 5);
        int zD = random.Next(2, 5);

        int[,,] arr3Dim = new int[xD, yD, zD];

        int[] tempArr = new int[arr3Dim.GetLength(0) * arr3Dim.GetLength(1) * arr3Dim.GetLength(2)];
        int number;

        for (int i = 0; i < tempArr.GetLength(0); i++)
        {
            tempArr[i] = random.Next(10, 100);
            number = tempArr[i];
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (tempArr[i] == tempArr[j])
                    {
                        tempArr[i] = random.Next(10, 100);
                        j = 0;
                        number = tempArr[i];
                    }
                    number = tempArr[i];
                }
            }
        }
        int count = 0;
        for (int x = 0; x < arr3Dim.GetLength(0); x++)
        {
            for (int y = 0; y < arr3Dim.GetLength(1); y++)
            {
                for (int z = 0; z < arr3Dim.GetLength(2); z++)
                {
                    arr3Dim[x, y, z] = tempArr[count];
                    count++;
                }
            }

        }
        WriteArray(arr3Dim);
    }
    void WriteArray(int[,,] arr3Dim)
    {
        for (int i = 0; i < arr3Dim.GetLength(0); i++)
        {
            for (int j = 0; j < arr3Dim.GetLength(1); j++)
            {
                Console.Write($"X({i}) Y({j}) ");
                for (int k = 0; k < arr3Dim.GetLength(2); k++)
                {
                    Console.Write($"Z({k})={arr3Dim[i, j, k]}; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
