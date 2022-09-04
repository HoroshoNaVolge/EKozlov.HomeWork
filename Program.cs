using static MyLibrary.MyMethods; // подключаем мои дополнительные методы.
using static MyLibrary.Message; // подключаем мои текстовые сообщения (статич. переменные типа string) для вывода в UI.

TaskManager taskManager = new TaskManager(ShowConsoleMessage); // инициализируем экземпляр менеджера задач. В данном случае передаем параметром метод вывода в консоль (консольная реализация UI).
bool isFirstExecution = true; // при первичном запуске отмечаем true для соответствующего приветствия пользователя.

while (taskManager.AskToStart(isFirstExecution)) // Работа программы допускается после завершения конкретной задачи, возвращается в метод AskToStart (запуск выбора задач).
{
    // инициализируем экземпляр конкретной задачи при помощи метода CreateTask класса TaskManager.
    taskManager.CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg));
    // метод GetConsoleInput(msg) - перегрузка Console.Readline с доп. логикой - возвращает преобразованный int после проверки. Описан в MyLibrary.MyMethods.

    taskManager.CurrentTask.Execute(); // запускаем выполнение конкретной задачи. Работаем через свойство CurrentTask класса Creator, а не напрямую с классом HomeworkTask.

    taskManager.ShowTaskResult(); //передаём в метод ShowMessage (в данной реализации вывод на консоль) string-свойство Result, обновленное по итогу выполнения метода Execute.

    isFirstExecution = false; // первичный запуск программы прошёл, меняем буль на false для вывода иного сообщения пользователю в дальнейшем.

    // Предусмотрено повторное выполнение той же задачи после её завершения (до выхода на уровень выбора номера задачи).
    while (taskManager.AskToRepeatTask()) // после выполнения конкретной задачи спрашиваем необходимо ли повторно запустить ту же задачу (например с другими входными данными).
    // В методе AskToRepeat при выборе повтора задачи создается новый экземпляр конкретной задачи Task и присваевается свойству CurrentTask класса TaskManager.
    {
        taskManager.CurrentTask.Execute(); // выполняем повторно задачу.
        taskManager.ShowTaskResult(); // выводим результат повторного выполнения задачи.
    }
}