using EKozlov.HomeWork.BL;

public class Task038 : HomeworkTask
{
    public Task038(bool noUserInputArgs) : base(noUserInputArgs)
    {
        Number = 38; // номер задачи согласно списку ДЗ 

        Description = $"Выполняется задача №{Number}: Программа задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементом массива.";
    }

    public override void Execute() //реализация задачи
    {
        // Массив ограничен 6 элементами и небольшим отрезком значений для улучшения читабельности результата.

        var arr = new double[random.Next(3, 6)].Select(d => random.Next(-100, 100) + random.NextDouble()).ToArray<double>();

        Result = $"В массиве [{GetSequenceInText(arr)}] разница между большим элементом и меньшим элементом = {Math.Round(arr.Max() - arr.Min(), 2).ToString().Replace(',', '.')}";
       
        // меняеv запятую на точку в отображении числа для исключения путаницы - в нашей строке элементы разделяются запятой.
    }
}