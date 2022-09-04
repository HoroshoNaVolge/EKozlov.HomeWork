using static MyLibrary.MyMethods;
public class Task_013 : HomeworkTask
{
    public Task_013() : base()
    {
        Number = 13; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет."; // описание задачи

        ConsoleMessage(Description); // вывод в UI информации о выбранной задаче

        Arguments = CreateArgumentsForTask(QuantityOfArguments); // создание массива аргументов для данной задачи через ввод пользователем (метод родительского класса Homework) 
    }

    public override void Execute() //реализация задачи
    {
        string tempStringNumber = Arguments[0].ToString(); // приводим int в строку 

        char[] charNumberInString = tempStringNumber.ToCharArray(); // массиву символов присваиваем строку, приведённую к типу массива символов

        if (charNumberInString.Length >= 3) // если в массиве символов 3 и более элемента, то третья цифра числа будет в массиве по индексу [2].

            if (charNumberInString[0] == '-') // если введено отрицательное число, тоесть первый элемент массива символов не цифра, а знак '-'.
                Result = $"Третья цифра числа {Arguments[0]}  => " + tempStringNumber[3]; // то присваиваем свойству Result результат выполнения метода Execute (4 символ по порядку, т.е. 3 цифра)

            else
                Result = $"Третья цифра числа {Arguments[0]}  => " + tempStringNumber[2]; // если true, то присваиваем свойству Result результат выполнения метода Execute


        else
            Result = $"В числе {Arguments[0]} третьей цифры нет"; // если false, то также присваиваем свойству Result результат выполнения метода Execute
    }
}