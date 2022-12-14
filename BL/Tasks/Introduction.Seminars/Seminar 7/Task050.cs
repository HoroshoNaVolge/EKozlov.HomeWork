using EKozlov.HomeWork.BL;
using System.Text;

public class Task050 : HomeworkTask
{
    public Task050() : base()
    {
        Number = 50;
        QuantityOfArguments = 2;
        SpecifiedArgumentsNames = new string[] { "индекс в строке", "индекс в столбце" };
        Description = $"\nВыполняется задача №{Number}:  Программа принимает позиции элемента в двумерном массиве"
                      + $"\nи возвращает значение этого элемента или же указание, что такого элемента нет.";
    }

    public override void Execute()
    {
        int rows = random.Next(2, 6);
        int columns = random.Next(2, 6);

        double[,] numbers = CreateDouble2DimArray(rows, columns);

        Result = $"\nДвухмерный массив размером {rows}x{columns}: \n" + stringBuilder.ToString() + "\n";

        double valueOfElementByIndex;

        try
        {
            valueOfElementByIndex = numbers[Arguments[0], Arguments[1]];

            Result += $"\nЭлемент на позиции [{Arguments[0]},{Arguments[1]}]: " + valueOfElementByIndex +" (нумерация индекса с нуля).\n";
        }

        catch (IndexOutOfRangeException)
        {
            Result += $"\nНа указанной позиции [{Arguments[0]},{Arguments[1]}] в массиве элемента нет (нумерация индекса с нуля).\n";
        }
    }
}