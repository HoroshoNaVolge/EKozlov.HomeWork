using MyLibrary;
using static MyLibrary.MyMethods;
using static MyLibrary.Message;

public class HomeworkTask
{
    // Родительский класс задачи из ДЗ.
    #region Свойства родительского класса
    /// <summary>
    /// Номер задачи согласно списку ДЗ
    /// </summary>
    public int Number { get; protected set; }
    /// <summary>
    /// Описание (текст) задачи.
    /// </summary>
    /// <value></value>
    public string Description { get; protected set; }
    /// <summary>
    /// Массив аргументов (целых чисел) для выполнения задачи.
    /// </summary>
    /// <value></value>
    public int[] Arguments { get; protected set; }
    /// <summary>
    /// Количество аргументов для задачи.
    /// </summary>
    /// <value></value>
    public int QuantityOfArguments { get; protected set; } // свойство, содержащее количество аргументов для задачи
    /// <summary>
    /// Результат выполнения задачи.
    /// </summary>
    /// <value></value>
    public string Result { get; protected set; } // свойство с результатом выполнения задачи

    #endregion

    #region Конструктор родительского типа
    /// <summary>
    /// Конструктор класса задачи.
    /// </summary>
    public HomeworkTask() 
    {
        Result = string.Empty; // для исключения null-reference
        Arguments = Array.Empty<int>(); // для исключения null-reference
        Description = string.Empty; // для исключения null-reference
    }
    #endregion

    #region Методы родительского класса 
    /// <summary>
    /// Метод выполнения решения задачи.
    /// </summary>
    public virtual void Execute()
    {
        // в родительском классе метод без конкретной реализации.
    }

    /// <summary>
    /// Метод создания аргументов задачи через ввод данных пользователем.
    /// </summary>
    /// <param name="numberOfArgs">Количество необходимых аргументов задачи. </param>
    /// <returns></returns>
    public int[] CreateArgumentsForTask(int numberOfArgs) // каждый наследник создаёт аргументы, исходя из необходимого количества аргументов согласно задаче.
    {
        int[] args = new int[numberOfArgs]; // 

        for (int x = 0; x < args.Length; x++)
        {
            args[x] = GetConsoleInput(invite_to_input_number_msg); // ввод через переопределенный метод ReadLine с tryParse.
        }
        return args;
    }
    #endregion
}
