using EKozlov.HomeWork.BL;

public class Task036 : HomeworkTask
{
    public Task036(bool noUserInputArgs) : base(noUserInputArgs)
    {
        Number = 36;

        Description = $"\nВыполняется задача №{Number}: Программа задаёт одномерный массив, заполненный случайными числами и находит сумму элементов, стоящих на нечётных позициях. ";
    }

    public override void Execute()
    {
        // Массив ограничен 6 элементами и небольшим отрезком значений для улучшения читабельности результата.

        var arr = new int[random.Next(3, 6)].Select(i => random.Next(-100, 101)).ToArray<int>();

        int sumByOddIndex = 0;

        for (int i = 1; i < arr.Length; i = i + 2) 
            sumByOddIndex += arr[i];

        Result = $"В массиве: [{GetSequenceInText(arr)}] сумма чисел на нечётных позициях (нумерация с нуля) : {sumByOddIndex}";
    }
}