using EKozlov.HomeWork.BL;

public class Task013 : HomeworkTask
{
    public Task013() : base()
    {
        Number = 13;

        QuantityOfArguments = 1;

        Description = $"\nВыполняется задача №{Number}: Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.";
    }

    public override void Execute()
    {
        string tempStringNumber = Arguments[0].ToString();

        char[] charNumberInString = tempStringNumber.ToCharArray();

        if (charNumberInString.Length >= 3)

            if (charNumberInString[0] == '-')
                Result = $"Третья цифра числа {Arguments[0]}  => " + tempStringNumber[3];

            else
                Result = $"Третья цифра числа {Arguments[0]}  => " + tempStringNumber[2];

        else
            Result = $"В числе {Arguments[0]} третьей цифры нет";
    }
}