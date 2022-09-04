using static MyLibrary.MyMethods;
using static MyLibrary.Message;
using static MyLibrary.MyConsole;

public class TaskCreator
{
    public HomeworkTask? CurrentTask { get; private set; } // допускаем NULL референс.
    public HomeworkTask CreateTask(int number) // Метод создания экземляра контретной задачи по указанному номеру.
    {
        switch (number) // новые задачи добавлять путем внесения кейса в switch.
        {
            case 2:
                return CurrentTask = new Task2(); // создание экземпляра задачи №2.
                break;
            case 4:
                return CurrentTask = new Task4(); // создание экземпляра задачи №4.
                break;
            case 6:
                return CurrentTask = new Task6(); // создание экземпляра задачи №6.
                break;
            case 8:
                return CurrentTask = new Task8(); // создание экземпляра задачи №8.
                break;
            case 10:
                return CurrentTask = new Task10(); // создание экземпляра задачи №10.
            case 13:
                return CurrentTask = new Task13(); // создание экземпляра задачи №13.
                break;
            case 15:
                return CurrentTask = new Task15(); // создание экземпляра задачи №15.


            default: // если никакой актуальный номер не введен.
                ShowMessage(not_actual_task_number_msg); // Выводит сообщение о неактуальном номере.
                return (CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg))); // Рекурсивный запрос на повторный ввод, пока не будет актуальный номер введен.
                break;
        }
    }

    public bool AskToStart(bool firstExecution) // проверка TaskCreator необходимо ли выполнять программу.

    {
        if (firstExecution) // если первый запуск программы.
        {
            ShowMessage(welcome_msg); // выводит приветствие. 
            return true; // возвращает true, так как это первый запуск программы.
        }

        else // если НЕ первый запуск программы.
        {
            if (GetYesOrNoInput(ask_to_continue_msg)) // запрос на продолжение (если да, возвращает true).
                return true;
            else // если нет,
            {
                ShowMessage(goodBye_msg); // выводит прощальное сообщение,
                return false; // возвращает false.
            }
        }
    }

    public virtual bool AskToRepeatTask() // проверка TaskCreator необходимо ли повторно запустить ту же задачу
    {

        if (GetYesOrNoInput(ask_to_repeat_task_msg)) // если ответ на повтор задачи положительный
        {
            CurrentTask = CreateTask(CurrentTask.Number); // в свойство текущей задачи кладёт новый экземпляр конкретной задачи с тем же номером.
            return true;
        }
        else// иначе ничего дополнительно не делает, возвращает false.
            return false;
    }

    

}
