using static MyLibrary.MyMethods;
using static MyLibrary.Message;

public class TaskManager
{
    private static TaskManager taskManager; // Паттерн Singleton. Приватная переменная экзмемпляра TaskManager.
    private bool firstExecution = true; // Первый запуск. Значение по умолчанию true. 

    #region Свойства класса TaskManager

    /// <summary>
    /// Свойство экземпляра конкретной задачи.
    /// </summary>
    public HomeworkTask CurrentTask { get; private set; }

    /// <summary>
    /// Свойство делегата вывода сообщений в UI.
    /// </summary>
    public MessageHandler MessageHandler { get; }

    /// <summary>
    /// Свойство делегата ввода данных из UI.
    /// </summary>
    public InputHandler InputHandler { get; }

    /// <summary>
    /// Свойство делегата получения "да" или "нет" от пользователя.
    /// </summary>
    public YesOrNoInputHandler YesOrNoInputHandler { get; }

    #endregion

    #region Конструктор и геттер singleton-класса TaskManager

    private TaskManager(MessageHandler messageHandler, InputHandler inputHandler, YesOrNoInputHandler yesOrNoInputHandler) // Паттерн Singleton. Приватный конструктор TaskManager.
    {
        MessageHandler = messageHandler; // присваиваем делегат вывода сообщений нашему readonly-свойству.
        InputHandler = inputHandler; // присваиваем делегат ввода данных нашему readonly-свойству.
        YesOrNoInputHandler = yesOrNoInputHandler; // присваиваем делегат получения "да" или "нет" от пользователя нашему readonly-свойству.
    }

    /// <summary>
    /// Возвращает экземпляр менеджера задач. Паттерн Singleton.
    /// </summary>
    public static TaskManager getInstance(MessageHandler messageHandler, InputHandler inputHandler, YesOrNoInputHandler yesOrNoInputHandler) // Статический геттер экземпляра класса TaskManager.
    {
        if (taskManager == null) // если экзмепляр класса еще не создавался
            return taskManager = new TaskManager(messageHandler, inputHandler, yesOrNoInputHandler); // возвращаем новый экземпляр класса ().
        return taskManager; // если уже есть объект - возвращаем ссылку на существующий экземпляр TaskManager.
    }

    #endregion

    #region Методы класса TaskManager

    /// <summary>
    /// Запуск менеджера выполнения задач.
    /// </summary>
    public void Run()
    {
        while (NeedToContinueProgram()) // пока необходимо продолжать выполнение программы (менеджера задач)
        {
            CreateTask(); // создаём задачу. 

            MessageHandler.Invoke(CurrentTask.Description); // выводим в UI текст созданной задачи.

            CurrentTask.Arguments = CreateArgumentsForTask(CurrentTask.QuantityOfArguments); // запрашиваем ввод пользователя аргументов для задачи.

            CurrentTask.Execute(); // выполняем задачу.

            MessageHandler.Invoke(CurrentTask.Result); // выводим в UI результат выполнения задачи.

            while (AskToRepeatTask()) // пока требуется повторение выполненной задачи (текущей).
            {
                MessageHandler?.Invoke(CurrentTask.Description); // выводим в UI текст текущей задачи.
                CurrentTask.Arguments = CreateArgumentsForTask(CurrentTask.QuantityOfArguments); // запрашиваем ввод пользователя аргументов для задачи.
                CurrentTask.Execute(); // выполняем задачу.
                MessageHandler.Invoke(CurrentTask.Result); // выводим в UI результат выполнения задачи.
            }
        }
    }

    /// <summary>
    /// Метод создания конкретной задачи.
    /// </summary>
    private void CreateTask()
    {
        int taskNumber = InputHandler.Invoke(INVITE_TO_INPUT_TASK_NUMBER_MSG); // запрашиваем у пользователя ввод номера задачи. 

        switch (taskNumber) // новые задачи добавляются путем внесения кейса (номера) в блок switch.
        {
            case 2:
                CurrentTask = new Task_002(); // создание экземпляра задачи №2.
                break;
            case 4:
                CurrentTask = new Task_004(); // создание экземпляра задачи №4.
                break;
            case 6:
                CurrentTask = new Task_006(); // создание экземпляра задачи №6.
                break;
            case 8:
                CurrentTask = new Task_008(); // создание экземпляра задачи №8.
                break;
            case 10:
                CurrentTask = new Task_010(); // создание экземпляра задачи №10.
                break;
            case 13:
                CurrentTask = new Task_013(); // создание экземпляра задачи №13.
                break;
            case 15:
                CurrentTask = new Task_015(); // создание экземпляра задачи №15.
                break;

            default: // если никакой актуальный номер не введен.
                MessageHandler.Invoke(INVALID_TASK_NUMBER_MSG); // Выводит сообщение о неактуальном номере задачи.
                CreateTask(); // Рекурсивный запрос на ввод, пока не будет актуальный номер введен.
                break;
        }
    }

    /// <summary>
    /// Проверка на необходимость выполнения программы.
    /// </summary>
    /// <param name="firstExecution">Является ли первым запуском программы. </param>
    /// <returns></returns>
    private int[] CreateArgumentsForTask(int numberOfArgs) // 
    {
        int[] args = new int[numberOfArgs]; // объявляем массив элементов (аргументы для выполнения операций в конкретной задаче)

        for (int x = 0; x < args.Length; x++) // пока полностью не получим необходимое количество аргументов для задачи,
        {
            args[x] = InputHandler.Invoke(INVITE_TO_INPUT_NUMBER_MSG); // запрашиваем ввод пользователя.
        }
        return args;
    }

    /// <summary>
    /// Проверка необходимости продолжения программы.
    /// </summary>
    /// <returns></returns>
    private bool NeedToContinueProgram()

    {
        if (firstExecution) // если это первый запуск программы. По умолчанию true.
        {
            MessageHandler.Invoke(WELCOME_MSG); // выводит приветствие пользователю.
            firstExecution = false; // указываем, что первый запуск прошёл.
            return true; // возвращает true, так как это первый запуск программы и выполнение необходимо по умолчанию.
        }

        else // если это не первый запуск программы, т.е. уже выполненена хотя бы 1 (одна) задача.
        {
            if (YesOrNoInputHandler.Invoke(ASK_TO_CONTINUE_MSG)) // запрос на продолжение (если ввод пользователя положительный, возвращает true).
                return true;
            else // если пользователь не хочет продолжать (т.е. ввод пользователя отрицательный),
            {
                MessageHandler.Invoke(GOODBYE_MSG); // выводит прощальное сообщение,
                return false; // возвращает false.
            }
        }
    }

    /// <summary>
    /// проверка на необходимость повторения той же (текущей) задачи.
    /// </summary>
    /// <returns></returns>
    private bool AskToRepeatTask()
    {
        if (YesOrNoInputHandler.Invoke(ASK_TO_REPEAT_TASK_MSG)) return true; // если ответ пользователя на запрос повторения задачи положительный
        else return false;// иначе ничего дополнительно не делает, возвращает false.

    }

#endregion

}