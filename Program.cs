using static MyLibrary.MyMethods;
using static MyLibrary.Message;

TaskCreator creator = new TaskCreator(); // инициализируем экземпляр создателя задач.
bool isFirstExecution = true; // при первичном запуске отмечаем true

while (creator.AskToStart(isFirstExecution)) // Работа программы допускается после завершения конкретной задачи, возвращается в метод AskToStart (запуск выбора задач)
{
    HomeworkTask currentTask = creator.CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg)); // инициализируем экземпляр конкретной задачи при помощи метода класса TaskCreator
    // метод GetConsoleInput(msg) - перегрузка Console.Readline с доп. логикой - возвращает преобразованный int после проверки. Описан в MyLibrary.MyMethods.
    ShowMessage(currentTask.Execute()); // передаём в метод ShowMessage (в данной реализации вывод на консоль) string-результат выполнения текущей задачи в методе Execute.
    while(currentTask.AskNeedToRepeatTask())
        ShowMessage(currentTask.Execute());

    isFirstExecution = false; // первичный запуск прошёл, меняем буль на false для вывода иного сообщения пользователю в дальнейшем
}