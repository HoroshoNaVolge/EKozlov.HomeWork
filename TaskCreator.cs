using MyLibrary;

public class TaskCreator
{
    public HomeworkTask CreateTask(int number)
    {
        switch (number)
        {
            case 2: return new Task2(); 
            break;
            case 4: return new Task4(); 
            break;
            case 6: return new Task6(); 
            break;
            case 8: return new Task8(); 
            break;
            
            default: Console.WriteLine(Message.not_implemented_task_number); 
                return (CreateTask(MyMethods.GetConsoleInput(Message.invite_to_input_hometask_number_msg)));
            break;
        }
    }

    public void AskToContinue()
    
    {

    }
}
