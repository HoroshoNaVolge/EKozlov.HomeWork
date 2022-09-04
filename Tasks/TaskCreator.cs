using static MyLibrary.MyMethods;
using static MyLibrary.Message;
using static MyLibrary.MyConsole;

public class TaskCreator
{
    public HomeworkTask CreateTask(int number) // Метод создания экземляра контретной задачи по указанному номеру
    {
        switch (number) // новые задачи добавлять путем внесения кейса в switch
        {
            case 2:
                return new Task2(); // создание экземпляра задачи №2
                break;
            case 4:
                return new Task4(); // создание экземпляра задачи №4
                break;
            case 6:
                return new Task6(); // создание экземпляра задачи №6
                break;
            case 8:
                return new Task8(); // создание экземпляра задачи №8
                break;
            case 10:
                return new Task10(); // создание экземпляра задачи №10
            case 13:
                return new Task13(); // создание экземпляра задачи №13
                break;
            case 15:
                return new Task15(); // создание экземпляра задачи №15
                

            default: // если никакой актуальный номер не введен
                ShowMessage(not_actual_task_number_msg); // Выводит сообщение о неактуальном номере
                return (CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg))); // Рекурсивный запрос на повторный ввод, пока не будет актуальный номер введен
                break;
        }
    }

    public bool AskToStart(bool firstExecution) // проверка TaskCreator необходимо ли выполнять программу

    {
        if (firstExecution) // если первый запуск программы
        {
            ShowMessage (welcome_msg); // выводит приветствие 
            return true;
        }

        else
        {
                        
            bool needToContinueProgram= GetYesOrNoInput(ask_to_continue_msg) == true? true: false;
           
            if (needToContinueProgram==false) ShowMessage(goodBye_msg);
            return needToContinueProgram;
        }
    }
}
