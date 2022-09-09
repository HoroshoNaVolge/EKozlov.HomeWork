using EKozlov.HomeWork.BL;

public class Task_021 : HomeworkTask
{
    public Task_021() : base()
    {
        Number = 21; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 6; // количество аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.";

        GroupedArguemnts=true; // по условию задачи у нас 2 группу аргументов. Используется для выдачи инструкций пользователю при вводе им аргументов в CreateArguments.
    }

    public override void Execute() //реализация задачи
    {
        //Формула: diff_a_b = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

        double diff_Pow_Xa_Xb = Math.Pow((double)(Arguments[0] - Arguments[3]), 2);

        double diff_Pow_Ya_Yb = Math.Pow((double)(Arguments[1] - Arguments[4]), 2);

        double diff_Pow_Za_Zb = Math.Pow((double)(Arguments[2] - Arguments[5]), 2);

        double diff_a_b = Math.Sqrt(diff_Pow_Xa_Xb + diff_Pow_Ya_Yb + diff_Pow_Za_Zb);

        Result = $"Расстояние между точками A({Arguments[0]},{Arguments[1]},{Arguments[2]}), B({Arguments[3]},{Arguments[4]},{Arguments[5]}) в 3D пространстве =  {diff_a_b}";
    }
}