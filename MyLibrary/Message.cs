namespace MyLibrary;
public static class Message // статичные переменные с текстом сообщений для вывода в UI
{
    public static string incorrect_input_msg = "Некорректный ввод. Повторите попытку ввода целого числа: ";
    public static string invite_to_input_number_msg = "Введите целое число: ";
    public static string invite_to_input_hometask_number_msg = "Введите номер актуальной задачи: ";
    public static string not_actual_task_number_msg = "Такой номер задачи отсутствует в актуальном задании. \nНомера актуальных задач описаны в 'README.md' ";
    public static string welcome_msg = "Добро пожаловать в мою программу по домашним заданиям. \nНомера актуальных задач описаны в 'README.md'";
    public static string ask_to_continue_msg = "Хотите ли Вы продолжить работу с другими задачами? y/n ";
    public static string ask_to_repeat_task_msg = "Повторить выполнение этой задачи? y/n ";    
    public static string goodBye_msg = "Программа проверки ДЗ завершена. Спасибо за внимание.";
    public static string checkedYes = "y"; // необходимо для проверки ввода с консоли (обработка в методе GetYesOrNoInput в MyMethods)
    public static string checkedNo = "n"; // необходимо для проверки ввода с консоли (обработка в методе GetYesOrNoInput в MyMethods)
    public static string not_chosen_yes_or_no_msg = "Некорретный ввод. Введите y или n: ";
}
