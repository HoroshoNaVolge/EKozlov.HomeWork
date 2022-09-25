using EKozlov.HomeWork.View;
using static EKozlov.HomeWork.View.IView;

namespace EKozlov.HomeWork.BL;
public class HomeWorkManager
{
    #region Приватные поля.
    // Паттерн Singleton. Приватная статич. переменная экзмемпляра TaskManager.
    private static HomeWorkManager _manager;

    // Ссылка на экземпляр исполнителя задач.
    private TaskExecutor _taskExecutor;

    // Ссылка на экземпляр UI.
    private IView _view;

    // Первый запуск. Значение по умолчанию true. 
    private bool _firstExecution = true;
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

    // Паттерн Singleton. Приватный конструктор TaskManager.
    private HomeWorkManager(IView userInterface)
    {
        _view = userInterface;
        ShowMessage = _view.ShowMessage;
        GetIntegerInput = _view.GetIntegerInput;
        GetYesOrNoInput = _view.GetYesOrNoInput;

        // Инициализируем экземпляр исполнителя задач, передаём ему метод запроса данных из UI и вывода сообщений в UI.
        _taskExecutor = new TaskExecutor(GetIntegerInput, ShowMessage);
    }

    /// <summary>
    /// Возвращает экземпляр менеджера задач. Паттерн Singleton.
    /// </summary>
    public static HomeWorkManager getInstance(IView userInterface)
    {
        if (_manager == null)
            return _manager = new HomeWorkManager(userInterface);
        return _manager;
    }

    #endregion

    #region Методы класса TaskManager

    /// <summary>
    /// Запуск менеджера выполнения задач.
    /// </summary>
    public void Run()
    {
        // Выполнение программы в цикле, пока пользователь не завершит.
        while (NeedToContinueProgram())
        {
            int taskNumber = GetIntegerInput.Invoke(MessageConstants.InviteInputTask);

            CreateTask(taskNumber);

            if (CurrentTask != null)
            {
                ShowMessage.Invoke(CurrentTask.Description);

                //Выполнение задачи и вывод в UI результата.
                ShowMessage.Invoke(_taskExecutor.ExecuteTask(CurrentTask));

                while (AskToRepeatTask())
                {
                    CreateTask(taskNumber);

                    ShowMessage.Invoke(CurrentTask.Description);

                    ShowMessage.Invoke(_taskExecutor.ExecuteTask(CurrentTask));
                }
            }
            else ShowMessage.Invoke(taskNumber + MessageConstants.InvalidTaskNumber);
        }
    }

    // Запрос на продолжения работы менеджера домашних заданий.
    private bool NeedToContinueProgram()

    {
        if (_firstExecution)
        {
            ShowMessage.Invoke(MessageConstants.Welcome);
            _firstExecution = false;
            return true;
        }

        // Если это не первый запуск программы, т.е. уже выполненена хотя бы 1 (одна) задача.
        else
        {
            if (GetYesOrNoInput.Invoke(MessageConstants.AskContinue))
            {
                _view.Clear();
                return true;
            }

            else
            {
                ShowMessage.Invoke(MessageConstants.GoodBye);
                return false;
            }
        }
    }
    // Запрос повтора выполнения текущей задачи.
    private bool AskToRepeatTask()
    {
        if (GetYesOrNoInput.Invoke(MessageConstants.AskRepeat))
            return true;


        else return false;
    }

    // Созадние экземпляра класса конкретной задачи.
    private void CreateTask(int taskNumber)
    {
        switch (taskNumber)
        {
            case 2:
                CurrentTask = new Task002();
                break;
            case 4:
                CurrentTask = new Task004();
                break;
            case 6:
                CurrentTask = new Task006();
                break;
            case 8:
                CurrentTask = new Task008();
                break;
            case 10:
                CurrentTask = new Task010();
                break;
            case 13:
                CurrentTask = new Task013();
                break;
            case 15:
                CurrentTask = new Task015();
                break;
            case 19:
                CurrentTask = new Task019();
                break;
            case 21:
                CurrentTask = new Task021();
                break;
            case 23:
                CurrentTask = new Task023();
                break;
            case 25:
                CurrentTask = new Task025();
                break;
            case 27:
                CurrentTask = new Task027();
                break;
            case 29:
                CurrentTask = new Task029();
                break;
            case 34:
                // Передаём аргумент true (bool noUserInput).
                CurrentTask = new Task034(true);
                break;
            case 36:
                CurrentTask = new Task036(true);
                break;
            case 38:
                CurrentTask = new Task038(true);
                break;
            case 41:
                CurrentTask = new Task041();
                break;
            case 43:
                CurrentTask = new Task043();
                break;
            case 47:
                CurrentTask = new Task047(true);
                break;
            case 50:
                CurrentTask = new Task050();
                break;
            case 52:
                CurrentTask = new Task052(true);
                break;

            default:
                CurrentTask = null;
                break;
        }
    }
    #endregion
}