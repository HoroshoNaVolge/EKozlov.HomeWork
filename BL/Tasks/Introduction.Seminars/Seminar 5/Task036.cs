using EKozlov.HomeWork.BL;

public class Task036 : HomeworkTask
{
    public Task036() : base()
    {
        Number = 36; // номер задачи согласно списку ДЗ 

        Description = $"Выполняется задача №{Number}: Программа задаёт одномерный массив, заполненный случайными числами и находит сумму элементов, стоящих на нечётных позициях. ";
    }

    public override void Execute() //реализация задачи
    {
        Random random = new Random();

        int[] array = new int[random.Next(2, 10)];


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-1000, 1000);

            Result += i != array.Length - 1 ? array[i] + ", " : array[i];
        }

        int sum = (from i in array where array[i] % 2 != 0 select i).Sum();

        Result = $"В массиве: [{Result}] сумма чисел на нечётных позициях (нумерация с нуля) : {sum}";
    }
}