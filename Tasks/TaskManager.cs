using static MyLibrary.MyMethods;
using static MyLibrary.Message;
using static MyLibrary.MyConsole;

public class TaskManager
{
    private static TaskManager? taskManager; // Паттерн Singleton. Приватная переменная экзмемпляра TaskManager. Может быть null.  

    #region Паттерн Singleton. Конструктор и геттер класса TaskManager

    private TaskManager(MessageHandler messageHandler) //Паттерн Singleton. Приватный конструктор TaskManager. Инициализация пустой задачи.
    {
        CurrentTask = new HomeworkTask(); // присваиваем пустую задачу (экземпляр родительского класса без параметров) в свойство CurrentTask.
        MessageHandler=messageHandler; // присваиваем аргумент нашему свойству делегата обработчика вывода 
    }

    public static TaskManager getInstance(MessageHandler messageHandler) // Паттерн Singleton. Статический геттер экземпляра класса TaskManager.
    {
        if (taskManager == null) // если экзмепляр класса еще не создавался
            return taskManager = new TaskManager(messageHandler); // возвращаем новый экземпляр класса (параметр: делегат обработчика вывода сообщений).
        return taskManager; // возвращаем ссылку на существующий экземпляр TaskManager.
    }

    #endregion

    #region Свойства класса TaskManager
    public HomeworkTask CurrentTask { get; private set; } // свойство, хранящее ссылку на экземпляр текущего задания.
    public MessageHandler MessageHandler { get; private set; } // свойство делегата для вывода сообщений в UI.
    #endregion

    #region Методы класса TaskManager
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
                MessageHandler?.Invoke(not_actual_task_number_msg); // Выводит сообщение о неактуальном номере.
                return (CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg))); // Рекурсивный запрос на повторный ввод, пока не будет актуальный номер введен.
        }
    }

    public bool AskToStart(bool firstExecution) // проверка TaskManager необходимо ли выполнять программу.

    {
        if (firstExecution) // если первый запуск программы.
        {
            MessageHandler?.Invoke(welcome_msg); // выводит приветствие. 
            return true; // возвращает true, так как это первый запуск программы.
        }

        else // если НЕ первый запуск программы.
        {
            if (GetYesOrNoInput(ask_to_continue_msg)) // запрос на продолжение (если да, возвращает true).
                return true;
            else // если нет,
            {
                MessageHandler?.Invoke(goodBye_msg); // выводит прощальное сообщение,
                return false; // возвращает false.
            }
        }
    }

    public void ShowTaskResult() => MessageHandler?.Invoke(CurrentTask.Result); // Метод вывода результата выполнения задачи в UI через делегат.

    public bool AskToRepeatTask() // проверка TaskManager необходимо ли повторно запустить ту же задачу.
    {

        if (GetYesOrNoInput(ask_to_repeat_task_msg)) // если ответ на повтор задачи положительный.
        {
            CurrentTask = CreateTask(CurrentTask.Number); // в свойство текущей задачи кладёт новый экземпляр конкретной задачи с тем же номером.
            return true;
        }
        else// иначе ничего дополнительно не делает, возвращает false.
            return false;
    }
    #endregion
}
