using EKozlov.HomeWork.BL;

public class Task027 : HomeworkTask
{
    public Task027() : base()
    {
        Number = 27;

        QuantityOfArguments = 1;

        Description = $"\nВыполняется задача №{Number}: Программа принимает на вход число и выдаёт сумму цифр в числе.";
    }

    public override void Execute() => Result = $"Сумма всех цифр в числе {Arguments[0]} = "
                                   + Arguments[0].ToString().Sum(Char.GetNumericValue).ToString();
}