using EKozlov.HomeWork.BL;

public class Task023 : HomeworkTask
{
    public Task023() : base()
    {
        Number = 23;

        QuantityOfArguments = 1;

        Description = $"\nВыполняется задача №{Number}: Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.";
    }

    public override void Execute()
    {
        Result = $"Таблица кубов от 1 до {Arguments[0]} включительно:  ";
        {
            if (Arguments[0] > 10000)
                Result = $"{Arguments[0]} - это слишком большое число для таблицы кубов. Давайте хотя бы до 10 тысяч.";

            else if (Arguments[0] == 1)
                Result += "1";
            else
            {
                // Int64 используем для обхода ограничения Int32 в 4 миллиарда. Так как считаем кубы.
                List<long> cubicalList = new List<long>();

                for (long i = 1; i <= Arguments[0]; i++)
                {
                    cubicalList.Add((long)Math.Pow(i, 3));
                }
                foreach (long i in cubicalList)
                    Result += i + " ";
            }
        }
    }
}