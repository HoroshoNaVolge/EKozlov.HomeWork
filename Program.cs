using static MyLibrary.MyMethods;
using static MyLibrary.Message;

TaskCreator creator = new TaskCreator(); // инициализируем экземпляр создателя задач.
bool isFirstExecution = true; // при первичном запуске отмечаем true

while (creator.AskToStart(isFirstExecution)) // Работа программы допускается после завершения конкретной задачи, возвращается в метод AskToStart (запуск выбора задач)
{
    HomeworkTask task = creator.CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg)); // инициализируем экземпляр конкретной задачи при помощи метода класса TaskCreator
    // метод GetConsoleInput(msg) - перегрузка Console.Readline с доп. логикой - возвращает преобразованный int после проверки. Описан в MyLibrary.MyMethods.
    task.Execute(); // передаём в метод ShowMessage (в данной реализации вывод на консоль) string-результат выполнения текущей задачи в методе Execute.
    ShowMessage(task.Result);
    while(creator.AskToRepeatTask()) // после выполнения задачи проверяем необходимо ли повторно запустить ту же задачу (например с другими входными данными).
        ShowMessage(creator.CurrentTask.Execute()); // выполняем повторно задачу. Создаётся новый экземпляр того же конкретного класса задачи.

    isFirstExecution = false; // первичный запуск программы прошёл, меняем буль на false для вывода иного сообщения пользователю в дальнейшем
}