using EKozlov.HomeWork.BL;

public class Task034 : HomeworkTask
{
    public Task034(bool noUserInputArgs) : base(noUserInputArgs)
    {
        Number = 34; // номер задачи согласно списку ДЗ 

        Description = $"Выполняется задача №{Number}: Программа задаёт массив, заполненный случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве. ";

    }

    public override void Execute() //реализация задачи
    {
        // Массив ограничен 6 элементами для улучшения читабельности результата.

        var array = new int[random.Next(2, 6)].Select(i => random.Next(100, 1000)).ToArray<int>();

        var evenCount = (from i in array where i % 2 == 0 select i).Count();

        Result = $"В массиве [{GetSequenceInText(array)}] количество чётных чисел : {evenCount}";
    }
}