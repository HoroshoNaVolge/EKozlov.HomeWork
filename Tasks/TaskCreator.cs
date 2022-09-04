using static MyLibrary.MyMethods;
using static MyLibrary.Message;
using static MyLibrary.MyConsole;

public class TaskCreator
{
    #region Конструктор класса TaskCreator
    //Конструктор TaskCreator. При инициализации хранит ссылку на объект задачи по умолчанию (пустая задача без реализации).
    public TaskCreator()
    {
        CurrentTask = new HomeworkTask();
    }
    #endregion

    #region Свойства класса TaskCreator
    public HomeworkTask CurrentTask { get; private set; } // свойство, хранящее ссылку на экземпляр текущего задания.
    #endregion

    #region Методы класса TaskCreator
    public HomeworkTask CreateTask(int number) // Метод создания экземляра контретной задачи по указанному номеру.
    {
        switch (number) // новые задачи добавлять путем внесения кейса в switch.
        {
            case 2:
                return CurrentTask = new Task_002(); // создание экземпляра задачи №2.
            case 4:
                return CurrentTask = new Task_004(); // создание экземпляра задачи №4.
            case 6:
                return CurrentTask = new Task_006(); // создание экземпляра задачи №6.
            case 8:
                return CurrentTask = new Task_008(); // создание экземпляра задачи №8.
            case 10:
                return CurrentTask = new Task_010(); // создание экземпляра задачи №10.
            case 13:
                return CurrentTask = new Task_013(); // создание экземпляра задачи №13.
            case 15:
                return CurrentTask = new Task_015(); // создание экземпляра задачи №15.

            default: // если никакой актуальный номер не введен.
                ShowMessage(not_actual_task_number_msg); // Выводит сообщение о неактуальном номере.
                return (CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg))); // Рекурсивный запрос на повторный ввод, пока не будет актуальный номер введен.
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

    public bool AskToRepeatTask() // проверка TaskCreator необходимо ли повторно запустить ту же задачу
    {

        if (GetYesOrNoInput(ask_to_repeat_task_msg)) // если ответ на повтор задачи положительный
        {
            CurrentTask = CreateTask(CurrentTask.Number); // в свойство текущей задачи кладёт новый экземпляр конкретной задачи с тем же номером.
            return true;
        }
        else// иначе ничего дополнительно не делает, возвращает false.
            return false;
    }
    #endregion
}
