using MyLibrary;
using static MyLibrary.MyMethods;
using static MyLibrary.Message;
using static MyLibrary.MyConsole;

public class TaskCreator
{
    public HomeworkTask CreateTask(int number)
    {
        switch (number)
        {
            case 2:
                return new Task2();
                break;
            case 4:
                return new Task4();
                break;
            case 6:
                return new Task6();
                break;
            case 8:
                return new Task8();
                break;

            default:
                Console.WriteLine(not_implemented_task_number);
                return (CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg)));
                break;
        }
    }

    public bool AskToStart(bool firstExecution)

    {
        if (firstExecution)
        {
            ShowMessage (welcome);
            return true;
        }

        else
        {
            string stringInput = ReadLine(askToContinue);
            if (stringInput.ToLower() == checkedYes)
            {
                return true;
            }
            else if (stringInput.ToLower()==checkedNo)
            {
                ShowMessage(goodBye);
                return false;
            }
            else
            {
                ShowMessage(notChosenYesOrNo);
                return AskToStart(false);
            }
        }
    }
}
