using MyLibrary;
using static MyLibrary.MyMethods;
using static MyLibrary.Message;
using static MyLibrary.MyConsole;

public class TaskCreator
{
    public HomeworkTask CreateTask(int number) // Метод создания экземляра контретной задачи по указанному номеру
    {
        switch (number) // новые задачи добавлять путем внесения кейса в switch
        {
            case 2:
                return new Task2(); // создание экземпляра задачи №2
                break;
            case 4:
                return new Task4();// создание экземпляра задачи №4
                break;
            case 6:
                return new Task6();// создание экземпляра задачи №6
                break;
            case 8:
                return new Task8();// создание экземпляра задачи №8
                break;

            default: // если никакой актуальный номер не введен
                Console.WriteLine(not_actual_task_number_msg); // Выводит сообщение о неактуальном номере
                return (CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg))); // Рекурсивный запрос на повторный ввод, пока не будет актуальный номер введен
                break;
        }
    }

    public bool AskToStart(bool firstExecution) // проверка TaskCreator необходимо ли выполнять программу

    {
        if (firstExecution) // если первый запуск программы
        {
            ShowMessage (welcome_msg); // выводит приветствие 
            return true;
        }

        else
        {
            string stringInput = ReadLine(ask_to_continue_msg); // иначе запрашивает необходимость продолжения программы после завершения конкретной задачи
            if (stringInput.ToLower() == checkedYes) // если ввод "y/Y" - продолжаем
            {
                return true;
            }
            else if (stringInput.ToLower()==checkedNo) // если ввод "n/N" - завершаем.
            {
                ShowMessage(goodBye_msg); // прощальное сообщение
                return false; 
            }
            else // если введен другой символ/символы
            {
                ShowMessage(not_chosen_yes_or_no_msg); // сообщение, что не выбран ни Y ни N 
                return AskToStart(false); // рекурсивный вызов ввода y или n
            }
        }
    }
}
