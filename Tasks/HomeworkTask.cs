using MyLibrary;
using static MyLibrary.MyMethods;
using static MyLibrary.Message;

public class HomeworkTask
{
    // Родительский класс задачи из ДЗ.
    #region Свойства родительского класса
    public int Number { get; protected set; } // свойство номера домашнего задания

    public string Description { get; protected set; } // свойство описания задачи (текст задачи)

    public int[] Arguments { get; protected set; } // свойство, содержащее массив аргументов (целых чисел) для выполнения задачи

    public int QuantityOfArguments { get; protected set; } // свойство, содержащее количество аргументов для задачи

    public string Result { get; protected set; } // свойство с результатом выполнения задачи

    #endregion

    #region Конструктор родительского типа
    public HomeworkTask() // конструктор класса домашнего задания
    {
        Result=string.Empty; // для исключения null-reference
        Arguments=Array.Empty<int>(); // для исключения null-reference
        Description=string.Empty; // для исключения null-reference
    }
    #endregion

    #region Методы родительского класса 

    public virtual void Execute() // Метод для выполнения решения задачи.
    {
        // в родительском классе метод без конкретной реализации.
    }

     public int[] CreateArgumentsForTask(int numberOfArgs) // каждый наследник создаёт аргументы, исходя из необходимого количества аргументов согласно задаче.
    {
        int[] args = new int[numberOfArgs];

        for (int x = 0; x < args.Length; x++)
        {
            args[x] = GetConsoleInput(invite_to_input_number_msg); //ввод через переопределенный метод ReadLine с tryParse.
        }
        return args;
    }
    #endregion
}
