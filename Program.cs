using EKozlov.HomeWork.BL; 
using EKozlov.HomeWork.View;

// Получаем экземпляр менеджера домашних заданий. В данной реализации передаем в качестве аргумента Консольный UI.
HomeWorkManager homeworkManager = HomeWorkManager.getInstance(new ConsoleUI());

// Запускаем выполнение менеджера домашних заданий.
homeworkManager.Run();