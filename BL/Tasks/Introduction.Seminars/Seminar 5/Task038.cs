using EKozlov.HomeWork.BL;

public class Task038 : HomeworkTask
{
    public Task038() : base()
    {
        Number = 38; // номер задачи согласно списку ДЗ 

        Description = $"Выполняется задача №{Number}: Программа задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.";
    }

    public override void Execute() //реализация задачи
    {
        Random random = new Random();

        int[] array = new int[random.Next(2, 10)]; // ограничение введено вместо ibt.MinValue и int.MaxValue просто для читабельности.

        int maxNum = 0;
        int minNum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-1000, 1000); // ограничение введено вместо ibt.MinValue и int.MaxValue просто для читабельности.

            if (i == 0) { minNum = array[i]; maxNum = array[i]; }


            maxNum = array[i] > maxNum ? array[i] : maxNum;
            minNum = array[i] < minNum ? array[i] : minNum;

            Result += i != array.Length - 1 ? array[i] + ", " : array[i];
        }

        Result = $"В массиве [{Result}] разница между большим элементом {maxNum} и меньшим элементом {minNum} = {maxNum - minNum}";
    }
}