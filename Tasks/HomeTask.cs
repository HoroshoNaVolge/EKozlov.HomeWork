using MyLibrary;

public class HomeworkTask 
{
    public int Number { get; } // readonly-свойство номера домашнего задания
    
    public byte QuantityOfArguments { get;  } // redonly-свойство количества аругментов на вход, которые требует задача (2,3...n входных чисел)
    public int[] Arguments{get;private set; } // свойство, содержащее аргументы для выполнения задачи

    public string Result { get; private set; } // свойство, содержащее результат выполнения задачи
    public HomeworkTask(int hometaskNumber) // конструктор класса домашнего задания
    {
        Number=hometaskNumber;
    }

    public void Run()
    {
        switch (Number)
        {
            case 2: CreateArgumentsForTask(2);
            break;
            case 4: CreateArgumentsForTask(3);
            break;
            case 6: CreateArgumentsForTask(1);
            break;
            case 8: CreateArgumentsForTask(1);
            break;
            default: Console.WriteLine(Message.not_implemented_task_number);
            break;
        }
    }

    public void CreateArgumentsForTask(int numberOfArgs)
    {
        int[] args = new int[numberOfArgs];
        
        for (int x=0; x<args.Length;x++)
        {
            args[x]=MyMethods.GetConsoleInput(Message.invite_to_input_number_msg);
        }
        Arguments=args;
    }
}