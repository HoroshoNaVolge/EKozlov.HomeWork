using EKozlov.HomeWork.BL;

internal class TaskExecutor
{
    private HomeworkTask _homeworkTask; // ссылка на экземпляр задачи.
    private IView.InputHandler _inputHandler; // ссылка на делегат ввода пользователем из UI.

    internal TaskExecutor(IView.InputHandler inputHandler) // конструктор класса, устанавливает метод запроса ввода пользователя
    {
        _inputHandler = inputHandler;
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
        _homeworkTask.Arguments = new int[quantityOfArgs]; // объявляем массив элементов (аргументы для выполнения операций в конкретной задаче)

        for (int i = 0; i < quantityOfArgs; i++) // пока полностью не получим необходимое количество аргументов для задачи,
        {
            _homeworkTask.Arguments[i] = _inputHandler.Invoke(MessageConstants.INVITE_TO_INPUT_NUMBER_MSG); // итеративно запрашиваем аргумент через ввод пользователя в UI.                                                            
        }
    }
}