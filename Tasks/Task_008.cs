using static MyLibrary.MyMethods;
public class Task_008 : HomeworkTask
{
    public Task_008() : base()
    {
        Number = 8; // номер задачи согласно списку ДЗ 

        QuantityOfArguments = 1; // количество входных аргументов согласно тексту задачи 

        Description = $"Выполняется задача №{Number}: Программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N."; // описание задачи

        ShowMessage(Description); // вывод в UI информации о выбранной задаче

        Arguments = CreateArgumentsForTask(QuantityOfArguments); // создание массива аргументов для данной задачи через ввод пользователем (метод родительского класса Homework) 
    } 

    public override void Execute() //реализация задачи
    {
        int tempVar = Arguments[0]; // кладём аргумент во временную переменную int

        List<int> oddNumbers = new List<int>();  // инициализируем список (коллекцию) int.

        for (int x = 1; x <= tempVar; x++) // для каждого элемента в диапазоне от 1 до числа N (наше введенное число)
        {
            if (x % 2 == 0) // если остаток от деления на 2 равен нулю , т.е. если число чётное
                oddNumbers.Add(x); // тогда данный элемент добавляем в список 
        }

        string listOfOdds = string.Empty; // инициализируем строку для вывода всех элементов списка чётных чисел 
        foreach (int x in oddNumbers) // для каждого элемента в списке чётных чисел 
        {
            listOfOdds += x.ToString() + " "; // добавляем в строку для вывода элемент списка и пробел (для читабельности вывода)
        }
        Result = $"Список всех чётных чисел от 1 до {Arguments[0]}: " + listOfOdds; // присваиваем свойству Result конечный результат
    }
}