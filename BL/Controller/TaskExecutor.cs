using EKozlov.HomeWork.BL;
using System.Text;
using static EKozlov.HomeWork.View.IView;

internal class TaskExecutor
{
    #region Приватные поля класса.
    // Именование через _ в соответствии с правилами именования приватных полей.
    private HomeworkTask _homeworkTask;
    private InputHandler _inputHandler;
    private MessageHandler _messageHandler;
    private StringBuilder _stringBuilder;
    #endregion

    #region Конструктор класса.
    /// <summary>
    /// Конструктор класса.
    /// </summary>
    /// <param name="inputHandler">Делегат ввода из UI.</param>
    /// <param name="messageHandler">Делегат вывода в UI.</param>
    internal TaskExecutor(InputHandler inputHandler, MessageHandler messageHandler)
    {
        _inputHandler = inputHandler;
        _messageHandler = messageHandler;
        _stringBuilder = new StringBuilder();
    }
    #endregion

    #region Методы класса.
    /// <summary>
    /// Метод выполнения задачи.
    /// </summary>
    /// <param name="currentTask">Номер задачи для выполнения.</param>
    /// <returns></returns>
    internal string ExecuteTask(HomeworkTask currentTask)
    {
        _homeworkTask = currentTask;

        if (_homeworkTask == null) return null;

        // Создаём конкретные аргументы для выполнения конкретной задачи.

        if (_homeworkTask.SpecifiedArgumentsNames == null)
            CreateArgumentsForTask(_homeworkTask.QuantityOfArguments);
        else
            CreateArgumentsForTask(_homeworkTask.SpecifiedArgumentsNames);

        _homeworkTask.Execute();

        return _homeworkTask.Result;
    }

    // Метод создания универсальных аргументов для задачи через ввод из UI.
    private void CreateArgumentsForTask(int quantityOfArgs)
    {

        _homeworkTask.Arguments = new int[quantityOfArgs];

        if (_homeworkTask.GroupedArguemnts) _messageHandler.Invoke($"\nВведите первые {quantityOfArgs / 2} значения");

        _stringBuilder.Append(MessageConstants.InviteInputNumber);


        for (var i = 0; i < quantityOfArgs; i++)
        {
            // После слова "введите" вставляем индекс+1 -> введите {индекс+1} целое число.
            _stringBuilder.Insert(8, i + 1 + "-е");

            // Если это группы аргументов, выводим в UI, когда достигнем половины.
            if (_homeworkTask.GroupedArguemnts)
                if (i == quantityOfArgs / 2)
                    _messageHandler.Invoke($"\nВведите следующие {quantityOfArgs / 2} значения");

            _homeworkTask.Arguments[i] = _inputHandler.Invoke(_stringBuilder.ToString());

            // Удаляем 3 символа по индексу после слова "Введите" ("{N} - e").
            _stringBuilder.Remove(8, 3);
        }

        _stringBuilder.Clear();
    }

    // Метод создания специфических аргументов для задачи через ввод из UI.
    private void CreateArgumentsForTask(string[] argsSpecificNames)
    {

        _homeworkTask.Arguments = new int[argsSpecificNames.Length];

        for (var i = 0; i < argsSpecificNames.Length; i++)
        {
            _stringBuilder.Append($"Введите {argsSpecificNames[i]}: ");

            _homeworkTask.Arguments[i] = _inputHandler.Invoke(_stringBuilder.ToString());

            _stringBuilder.Clear();
        }
    }
    #endregion
}