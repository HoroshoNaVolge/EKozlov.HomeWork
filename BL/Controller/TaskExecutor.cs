using EKozlov.HomeWork.BL;
using static EKozlov.HomeWork.View.IView;

internal class TaskExecutor
{
    #region Приватные поля класса.
    private HomeworkTask _homeworkTask; // ссылка на экземпляр задачи.
    private InputHandler _inputHandler; // ссылка на делегат ввода пользователем из UI.
    private MessageHandler _messageHandler; // ссылка на делегат вывода сообщения в UI.
    #endregion
    
    /// <summary>
    /// Конструктор класса.
    /// </summary>
    /// <param name="inputHandler">Делегат ввода из UI.</param>
    /// <param name="messageHandler">Делегат вывода в UI.</param>
    internal TaskExecutor(InputHandler inputHandler, MessageHandler messageHandler) 
    {
        _inputHandler = inputHandler;
        _messageHandler = messageHandler;
    }

    /// <summary>
    /// Метод выполнения задачи.
    /// </summary>
    /// <param name="currentTask">Номер задачи для выполнения.</param>
    /// <returns></returns>
    internal string ExecuteTask(HomeworkTask currentTask) 
    {
        _homeworkTask=currentTask;

        if (_homeworkTask != null)
        {
            CreateArgumentsForTask(_homeworkTask.QuantityOfArguments); // создаём конкретные аргументы для выполнения конкретной задачи.

            _homeworkTask.Execute(); // выполняем задачу.
            return _homeworkTask.Result;
        }
        return null;
    }

    private void CreateArgumentsForTask(int quantityOfArgs) // метод создания аргументов для задачи.
    {
        bool groupedArguments = _homeworkTask.GroupedArguemnts; // определяет, нужно ли делить аргументы на группы (только для соответствующего отображения в консоль)

        _homeworkTask.Arguments = new int[quantityOfArgs]; // объявляем массив элементов (аргументы для выполнения операций в конкретной задаче)

        if (groupedArguments) _messageHandler.Invoke($"Введите первые {quantityOfArgs/2} значения: ");

        for (int i = 0; i < quantityOfArgs; i++) // пока полностью не получим необходимое количество аргументов для задачи,
        {
            if (groupedArguments) // если это группы аргументов
                if(i==quantityOfArgs/2) // когда набираем половину необходимых аргументов  
                    _messageHandler.Invoke($"Введите следующие {quantityOfArgs/2} значения "); // просто отображаем в UI. Пока этого достаточно.
            _homeworkTask.Arguments[i] = _inputHandler.Invoke(MessageConstants.INVITE_TO_INPUT_NUMBER_MSG); // итеративно запрашиваем аргумент через ввод пользователя в UI.                                                            
        }
    }
}