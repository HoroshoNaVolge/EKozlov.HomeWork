using EKozlov.HomeWork.BL;

public class Task021 : HomeworkTask
{
    public Task021() : base()
    {
        Number = 21;

        QuantityOfArguments = 6;

        Description = $"\nВыполняется задача №{Number}: принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.";

        // По условию задачи у нас 2 группу аргументов. Используется для выдачи инструкций пользователю при вводе им аргументов в CreateArguments.
        GroupedArguemnts = true;
    }

    public override void Execute() //реализация задачи
    {
        // Формула: diffResult = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

        double diffPowXab = Math.Pow((double)(Arguments[0] - Arguments[3]), 2);

        double diffPowYab = Math.Pow((double)(Arguments[1] - Arguments[4]), 2);

        double diffPowZab = Math.Pow((double)(Arguments[2] - Arguments[5]), 2);

        double diffResult = Math.Sqrt(diffPowXab + diffPowYab + diffPowZab);

        Result = $"Расстояние между точками A({Arguments[0]},{Arguments[1]},{Arguments[2]}), B({Arguments[3]},{Arguments[4]},{Arguments[5]}) " +
                 $"в 3D пространстве =  {diffResult}";
    }
}