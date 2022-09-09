using EKozlov.HomeWork.BL;

public class Task_023 : HomeworkTask
{
    public Task_023() : base()
    {
        Number = 23; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.";
    }

    public override void Execute() //реализация задачи
    {

        List<long> cubicalList = new List<long>();

        for (long i = 1; i < Arguments[0]; i++)
        {
            cubicalList.Add(i * i * i);
        }
        foreach (long i in cubicalList)
            Result += i + " ";
    }
}