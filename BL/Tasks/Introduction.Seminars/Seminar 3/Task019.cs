using EKozlov.HomeWork.BL;

public class Task019 : HomeworkTask
{
    public Task019() : base()
    {
        Number = 19; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.";
    }

    public override void Execute() //реализация задачи
    {
        if ((Arguments[0] / 100 < 100 || Arguments[0] / 100 >= 1000)) // проверка, что число пятизначное.
            Result = $"{Arguments[0]} не пятизначное число.";
        else
        {
            char[] charArray = Arguments[0].ToString().ToCharArray();

            bool palyndrome;

            if (charArray[0] == charArray[4]) // реализуем конкретно для пятизначного числа, как в условии задачи.

                if (charArray[1] == charArray[3])

                    palyndrome = true;

                else palyndrome = false;

            else palyndrome = false;
            
            Result = palyndrome ? $"Число {Arguments[0]} является палиндромом" : $"Число {Arguments[0]} не является палиндромом.";
        }

    }
}