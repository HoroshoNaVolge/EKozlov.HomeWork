using EKozlov.HomeWork.BL;

public class Task027 : HomeworkTask
{
    public Task027() : base()
    {
        Number = 27; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход число и выдаёт сумму цифр в числе.";
    }

    public override void Execute() //реализация задачи
    {
        Result = $"Сумма всех цифр в числе {Arguments[0]}= " + Arguments[0].ToString().Sum(Char.GetNumericValue).ToString();
    }
}