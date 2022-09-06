using static MyLibrary.MyMethods; // подключаем дополнительные методы.

TaskManager taskManager = TaskManager.getInstance(ConsoleMessage, GetConsoleInput, GetYesOrNoConsoleInput); // получаем экземпляр менеджера задач (паттерн Singleton). В данной реализации передаем методы работы с консолью.

taskManager.Run(); // запускаем выполнение конкретной задачи. Работаем через свойство CurrentTask класса TaskManager, а не напрямую с классом HomeworkTask.