using static MyLibrary.MyMethods; // подключаем дополнительные методы.
using static MyLibrary.Message; // подключаем текстовые сообщения (статич. переменные типа string) для вывода в UI.

TaskManager taskManager = TaskManager.getInstance(ConsoleMessage); // получаем экземпляр менеджера задач (паттерн Singleton). В данной реализации передаем метод вывода в консоль.
bool isFirstExecution = true; // при первичном запуске отмечаем true для соответствующего приветствия пользователя.

while (taskManager.AskToStart(isFirstExecution)) // Работа программы допускается после завершения конкретной задачи, возвращается в метод AskToStart (запуск выбора задач).
{
    taskManager.CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg)); // инициализируем экземпляр конкретной задачи при помощи метода CreateTask класса TaskManager.

    taskManager.CurrentTask.Execute(); // запускаем выполнение конкретной задачи. Работаем через свойство CurrentTask класса TaskManager, а не напрямую с классом HomeworkTask.

    taskManager.ShowTaskResult(); //вызываем вывод сообщения с результатом в UI.

    isFirstExecution = false; // первичный запуск программы прошёл, меняем буль на false для вывода иного сообщения пользователю в дальнейшем.

    while (taskManager.AskToRepeatTask()) // после выполнения конкретной задачи спрашиваем необходимо ли повторно запустить ту же задачу (например с другими входными данными).
    // В методе AskToRepeat при выборе повтора задачи создается новый экземпляр конкретной задачи Task и присваевается свойству CurrentTask экземпляра TaskManager.
    {
        taskManager.CurrentTask.Execute(); // выполняем повторно задачу.
        taskManager.ShowTaskResult(); // выводим результат повторного выполнения задачи.
    }
}