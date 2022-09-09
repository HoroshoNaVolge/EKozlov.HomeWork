using EKozlov.HomeWork.View;
using static EKozlov.HomeWork.View.IView;

namespace EKozlov.HomeWork.BL;
public class HomeWorkManager
{
    #region Приватные поля.
    private static HomeWorkManager _manager; // Паттерн Singleton. Приватная статич. переменная экзмемпляра TaskManager.
    private TaskExecutor _taskExecutor; // Ссылка на экземпляр исполнителя задач.
    private bool _firstExecution = true; // Первый запуск. Значение по умолчанию true. 
    #endregion

    #region Свойства класса TaskManager

    /// <summary>
    /// Ссылка на экземпляр конкретной задачи.
    /// </summary>
    public HomeworkTask CurrentTask { get; private set; }

    /// <summary>
    /// Делегат вывода сообщений в UI.
    /// </summary>
    public MessageHandler ShowMessage { get; }

    /// <summary>
    /// Делегат ввода данных из UI.
    /// </summary>
    public InputHandler GetIntegerInput { get; }

    /// <summary>
    /// Делегат получения "да" или "нет" от пользователя.
    /// </summary>
    public YesOrNoInputHandler GetYesOrNoInput { get; }

    #endregion

    #region Конструктор и геттер singleton-класса TaskManager

    private HomeWorkManager(IView userInterface) // Паттерн Singleton. Приватный конструктор TaskManager.
    {
        ShowMessage = userInterface.ShowMessage; // присваиваем делегат вывода сообщений нашему readonly-свойству.
        GetIntegerInput = userInterface.GetIntegerInput; // присваиваем делегат ввода данных нашему readonly-свойству.
        GetYesOrNoInput = userInterface.GetYesOrNoInput; // присваиваем делегат получения "да" или "нет" от пользователя нашему readonly-свойству.
        _taskExecutor = new TaskExecutor(GetIntegerInput, ShowMessage); // инициализируем экземпляр исполнителя задач, передаём ему метод запроса данных из UI и вывода сообщений в UI.
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
            int taskNumber = GetIntegerInput.Invoke(MessageConstants.INVITE_TO_INPUT_TASK_NUMBER_MSG); // получаем ввод номера задачи от пользователя.

            CreateTask(taskNumber); // создаём задачу. 

            if (CurrentTask != null) // если задача по введенному номеру предусмотрена и создана.
            {
                ShowMessage.Invoke(CurrentTask.Description);// выводим в UI текст созданной задачи.

                ShowMessage.Invoke(_taskExecutor.ExecuteTask(CurrentTask)); // выполняем через класс исполнителя задач и выводим в UI результат выполнения.

                while (AskToRepeatTask()) // пока требуется повторение выполненной задачи (текущей).
                {
                    CreateTask(taskNumber); // создаём задачу заново. 

                    ShowMessage.Invoke(CurrentTask.Description); // выводим в UI текст созданной задачи.

                    ShowMessage.Invoke(_taskExecutor.ExecuteTask(CurrentTask)); // выводим в UI результат выполнения задачи.
                }
            }
            else ShowMessage.Invoke(taskNumber+MessageConstants.INVALID_TASK_NUMBER_MSG); // иначе выводим сообщение, что задачи с таким номером не предусмотрено.
        }
    }

    private bool NeedToContinueProgram() // запрос на продолжения работы менеджера домашних заданий.

    {
        if (_firstExecution) // если это первый запуск программы. По умолчанию true.
        {
            ShowMessage.Invoke(MessageConstants.WELCOME_MSG); // выводит приветствие пользователю.
            _firstExecution = false; // указываем, что первый запуск прошёл.
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

    private bool AskToRepeatTask() // запрос повтора выполнения текущей задачи.
    {
        if (GetYesOrNoInput.Invoke(MessageConstants.ASK_TO_REPEAT_TASK_MSG))
            return true; // если ответ пользователя на запрос повторения задачи положительный
        else return false;
    }

    private void CreateTask(int taskNumber) // созадние экземпляра класса конкретной задачи.
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