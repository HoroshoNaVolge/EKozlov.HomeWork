using MyLibrary;
using static MyLibrary.MyMethods;
using static MyLibrary.Message;

public class HomeworkTask
{
    #region Свойства
    public int Number { get; protected set; } // readonly-свойство номера домашнего задания

    public string Description { get; protected set; } // readonly-свойство. Описания задачи

    public int[] Arguments { get; protected set; } // свойство, содержащее аргументы для выполнения задачи

    public int QuantityOfArguments { get; protected set; }


    public string Result { get; protected set; }
    #endregion

    #region Конструктор родительского типа ДЗ
    public HomeworkTask() // конструктор класса домашнего задания
    {
        ShowMessage(Description);
    }
    #endregion

    public int[] CreateArgumentsForTask(int numberOfArgs)
    {
        int[] args = new int[numberOfArgs];

        for (int x = 0; x < args.Length; x++)
        {
            args[x] = GetConsoleInput(invite_to_input_number_msg);
        }
        return args;
    }

    public virtual string Execute()
    {
        return null;
    }
}
