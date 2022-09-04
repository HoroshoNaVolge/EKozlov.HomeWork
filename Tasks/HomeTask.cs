using MyLibrary;
using static MyLibrary.MyMethods;
using static MyLibrary.Message;

public class HomeworkTask
{
    // Родительский класс задачи из ДЗ
    #region Свойства
    public int Number { get; protected set; } // свойство номера домашнего задания

    public string Description { get; protected set; } // свойство описания задачи (текст задачи)

    public int[] Arguments { get; protected set; } // свойство, содержащее массив аргументов (целых чисел) для выполнения задачи

    public int QuantityOfArguments { get; protected set; } // свойство, содержащее количество аргументов для задачи

    public string Result { get; protected set; } // свойство с результатом выполнения задачи
    #endregion

    #region Конструктор родительского типа
    public HomeworkTask() // конструктор класса домашнего задания
    {

    }
    #endregion

    #region Методы класса 
    public int[] CreateArgumentsForTask(int numberOfArgs) // каждый наследник создаёт аргументы, исходя из необходимого количества аргументов согласно задаче
    {
        int[] args = new int[numberOfArgs];

        for (int x = 0; x < args.Length; x++)
        {
            args[x] = GetConsoleInput(invite_to_input_number_msg); //ввод через переопределенный метод ReadLine с tryParse
        }
        return args;
    }

    public virtual string Execute() // Метод для выполнения решения задачи
    {
        return string.Empty;
    }

    public virtual bool AskNeedToRepeatTask()
    {
        bool needToRepeatTask = GetYesOrNoInput(ask_to_repeat_task_msg) == true ? true : false;

        if (needToRepeatTask)
        {
            this.Arguments = this.CreateArgumentsForTask(this.QuantityOfArguments); 
            return needToRepeatTask;
        }
        else
            return false;
    }
    
    #endregion
}
