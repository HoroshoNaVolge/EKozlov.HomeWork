using EKozlov.HomeWork.View;

namespace EKozlov.HomeWork.BL;
public class HomeWorkManager
{
    #region Приватные поля.
    private static HomeWorkManager _manager; // Паттерн Singleton. Приватная переменная экзмемпляра TaskManager.
    private TaskExecutor _taskExecutor; // Ссылка на экземпляр исполнителя задач.
    private bool firstExecution = true; // Первый запуск. Значение по умолчанию true. 
    #endregion

    #region Свойства класса TaskManager

    /// <summary>
    /// Свойство экземпляра конкретной задачи.
    /// </summary>
    public HomeworkTask CurrentTask { get; private set; }

    /// <summary>
    /// Свойство делегата вывода сообщений в UI.
    /// </summary>
    public IView.MessageHandler ShowMessage { get; }

    /// <summary>
    /// Свойство делегата ввода данных из UI.
    /// </summary>
    public IView.InputHandler GetIntegerInput { get; }

    /// <summary>
    /// Свойство делегата получения "да" или "нет" от пользователя.
    /// </summary>
    public IView.YesOrNoInputHandler GetYesOrNoInput { get; }

    #endregion

    #region Конструктор и геттер singleton-класса TaskManager

    private HomeWorkManager(IView userInterface) // Паттерн Singleton. Приватный конструктор TaskManager.
    {
        ShowMessage = userInterface.ShowMessage; // присваиваем делегат вывода сообщений нашему readonly-свойству.
        GetIntegerInput = userInterface.GetIntegerInput; // присваиваем делегат ввода данных нашему readonly-свойству.
        GetYesOrNoInput = userInterface.GetYesOrNoInput; // присваиваем делегат получения "да" или "нет" от пользователя нашему readonly-свойству.
        _taskExecutor = new TaskExecutor(GetIntegerInput); // инициализируем экземпляр исполнителя задач, передаём ему метод запроса данных из UI.
    }

    /// <summary>
    /// Возвращает экземпляр менеджера задач. Паттерн Singleton.
    /// </summary>
    public static HomeWorkManager getInstance(IView userInterface) // Статический геттер экземпляра класса TaskManager.
    {
        if (_manager == null) // если экзмепляр класса еще не создавался
            return _manager = new HomeWorkManager(userInterface); // возвращаем новый экземпляр класса ().
        return _manager; // если уже есть объект - возвращаем ссылку на существующий экземпляр TaskManager.
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
            int taskNumber = GetIntegerInput.Invoke(MessageConstants.INVITE_TO_INPUT_TASK_NUMBER_MSG);

            CreateTask(taskNumber); // создаём задачу. 

            if (CurrentTask != null)
            {
                ShowMessage.Invoke(CurrentTask.Description);// выводим в UI текст созданной задачи.

                ShowMessage.Invoke(_taskExecutor.ExecuteTask(CurrentTask)); // выводим в UI результат выполнения задачи.


                while (AskToRepeatTask()) // пока требуется повторение выполненной задачи (текущей).
                {
                    CreateTask(taskNumber); // создаём задачу. 

                    ShowMessage.Invoke(CurrentTask.Description); // выводим в UI текст созданной задачи.

                    ShowMessage.Invoke(_taskExecutor.ExecuteTask(CurrentTask)); // выводим в UI результат выполнения задачи.

                }
            }
            else ShowMessage.Invoke(MessageConstants.INVALID_TASK_NUMBER_MSG);
        }
    }

    /// <summary>
    /// Проверка необходимости продолжения программы.
    /// </summary>
    /// <returns></returns>
    private bool NeedToContinueProgram()

    {
        if (firstExecution) // если это первый запуск программы. По умолчанию true.
        {
            ShowMessage.Invoke(MessageConstants.WELCOME_MSG); // выводит приветствие пользователю.
            firstExecution = false; // указываем, что первый запуск прошёл.
            return true; // возвращает true, так как это первый запуск программы и выполнение необходимо по умолчанию.
        }

        else // если это не первый запуск программы, т.е. уже выполненена хотя бы 1 (одна) задача.
        {
            if (GetYesOrNoInput.Invoke(MessageConstants.ASK_TO_CONTINUE_MSG)) // запрос на продолжение (если ввод пользователя положительный, возвращает true).
                return true;
            else // если пользователь не хочет продолжать (т.е. ввод пользователя отрицательный),
            {
                ShowMessage.Invoke(MessageConstants.GOODBYE_MSG); // выводит прощальное сообщение,
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
        if (GetYesOrNoInput.Invoke(MessageConstants.ASK_TO_REPEAT_TASK_MSG))
            return true; // если ответ пользователя на запрос повторения задачи положительный
        else return false;
    }

    private void CreateTask(int taskNumber)
    {
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
            case 19:
                CurrentTask = new Task_019(); // создание экземпляра задачи №15.
                break;
            case 21:
                CurrentTask = new Task_021(); // создание экземпляра задачи №15.
                break;
            case 23:
                CurrentTask = new Task_023(); // создание экземпляра задачи №15.
                break;

            default: // если никакой актуальный номер не введен.
                CurrentTask = null;
                break;
        }
    }
    #endregion

}