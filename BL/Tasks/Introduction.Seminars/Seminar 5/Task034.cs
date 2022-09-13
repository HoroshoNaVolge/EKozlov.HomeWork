using EKozlov.HomeWork.BL;

public class Task034 : HomeworkTask
{
    public Task034() : base()
    {
        Number = 34; // номер задачи согласно списку ДЗ 

        Description = $"Выполняется задача №{Number}: Программа задаёт массив, заполненный случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве. ";
    }

    public override void Execute() //реализация задачи
    {
        Random random = new Random();

        int[] array = new int[random.Next(2, 10)];


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);

            Result += i != array.Length - 1 ? array[i] + ", " : array[i];
        }

        int odds = (from i in array where i % 2 == 0 select i).Count();


        Result = $"В массиве [{Result}] количество чётных чисел : {odds}";
    }
}