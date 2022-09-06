using static MyLibrary.MyMethods;
using static MyLibrary.Message;
using static MyLibrary.MyConsole;

public class TaskManager
{
    private static TaskManager? taskManager; // Паттерн Singleton. Приватная переменная экзмемпляра TaskManager. Может быть null.  

    #region Свойства класса TaskManager

    /// <summary>
    /// Свойство экземпляра конкретной задачи.
    /// </summary>
    public HomeworkTask CurrentTask { get; private set; }

    /// <summary>
    /// Свойство делегата вывода сообщений в UI.
    /// </summary>
    public MessageHandler MessageHandler { get; } // readonly, т.к. менеджер задачи создаётся один раз в начале программы.

    #endregion

    #region Конструктор и геттер singleton-класса TaskManager

    private TaskManager(MessageHandler messageHandler) //Паттерн Singleton. Приватный конструктор TaskManager. Инициализация пустой задачи.
    {
        CurrentTask = new HomeworkTask(); // присваиваем пустую задачу (экземпляр родительского класса) в свойство CurrentTask.// TODO переписать. 
        MessageHandler = messageHandler; // присваиваем аргумент нашему readonly-свойству делегата обработчика вывода 
    }
    /// <summary>
    /// Возвращает экземпляр менеджера задач. Паттерн Singleton.
    /// </summary>
    /// <param name="messageHandler">Делегат вывода сообщений в UI</param>
    /// <returns></returns>
    public static TaskManager getInstance(MessageHandler messageHandler) // Статический геттер экземпляра класса TaskManager.
    {
        if (taskManager == null) // если экзмепляр класса еще не создавался
            return taskManager = new TaskManager(messageHandler); // возвращаем новый экземпляр класса ().
        return taskManager; // если уже есть объект - возвращаем ссылку на существующий экземпляр TaskManager.
    }

    #endregion

    #region Методы класса TaskManager
    /// <summary>
    /// Метод создания конкретной задачи.
    /// </summary>
    /// <param name="number">Номер задачи для создания.</param>
    /// <returns></returns>
    public HomeworkTask CreateTask(int number)
    {
        switch (number) // новые задачи добавляются путем внесения кейса (номера) в блок switch.
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
    /// <summary>
    /// Проверка на необходимость выполнения программы.
    /// </summary>
    /// <param name="firstExecution">Является ли первым запуском программы. </param>
    /// <returns></returns>
    public bool AskToStart(bool firstExecution)

    {
        if (firstExecution) // если это первый запуск программы.
        {
            MessageHandler?.Invoke(welcome_msg); // выводит приветствие. 
            return true; // возвращает true, так как это первый запуск программы.
        }

        else // если НЕ первый запуск программы, т.е. уже выполненена 1 (одна) задача.
        {
            if (GetYesOrNoConsoleInput(ask_to_continue_msg)) // запрос на продолжение (если да, возвращает true).
                return true;
            else // если пользователь не хочет продолжать,
            {
                MessageHandler?.Invoke(goodBye_msg); // выводит прощальное сообщение,
                return false; // возвращает false.
            }
        }
    }

    /// <summary>
    /// Метод вывода результата выполнения задачи в UI через делегат. 
    /// </summary>
    public void ShowTaskResult() => MessageHandler?.Invoke(CurrentTask.Result);

    /// <summary>
    /// проверка на необходимость повторения той же (текущей) задачи.
    /// </summary>
    /// <returns></returns>
    public bool AskToRepeatTask()
    {

        if (GetYesOrNoConsoleInput(ask_to_repeat_task_msg)) // если ответ пользователя на запрос повторения задачи положительный
        {
            CurrentTask = CreateTask(CurrentTask.Number); // в свойство текущей задачи кладёт новый экземпляр конкретной задачи с тем же номером.
            return true;
        }
        else// иначе ничего дополнительно не делает, возвращает false.
            return false;
    }
    #endregion
}
