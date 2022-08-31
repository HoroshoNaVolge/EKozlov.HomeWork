using MyLibrary;

public class HomeworkTask
{
    #region Свойства
    public int Number { get; protected set; } // readonly-свойство номера домашнего задания

    public string Description {get; protected set;} // readonly-свойство. Описания задачи

    public int[] Arguments { get; protected set; } // свойство, содержащее аргументы для выполнения задачи

    public int QuantityOfArguments { get; protected set; }


    public string Result { get; protected set; }
    #endregion
    
    #region Конструктор
    public HomeworkTask() // конструктор класса домашнего задания
    {
        Console.WriteLine(Description);
    }
    #endregion

    public int[] CreateArgumentsForTask(int numberOfArgs)
    {
        int[] args = new int[numberOfArgs];

        for (int x = 0; x < args.Length; x++)
        {
            args[x] = MyMethods.GetConsoleInput(Message.invite_to_input_number_msg);
        }
        return args;
    }

    public virtual string ExecuteTask()
    {
        return null;
    }
}
