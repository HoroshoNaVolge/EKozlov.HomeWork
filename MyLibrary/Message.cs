namespace MyLibrary;
public static class Message // статичные переменные с текстом сообщений для вывода в UI
{
    public static string incorrect_input_msg = "Некорректный ввод. Повторите попытку ввода целого числа: ";
    public static string invite_to_input_number_msg = "Введите целое число: ";
    public static string invite_to_input_hometask_number_msg = "Введите номер задачи: ";
    public static string not_implemented_task_number = "Такой номер задачи отсутствует в актуальном задании. \nНомера актуальных задач описаны в 'README.md' ";
    public static string welcome = "Добро пожаловать в мою программу по домашним заданиям. \nНомера актуальных задач описаны в 'README.md'";
    public static string askToContinue = "Хотите ли Вы продолжить работу с другими задачами? y/n   ";
    public static string goodBye = "Спасибо за внимание. Буду очень признателен за критику/конкретные советы, что лучше делать по другому.";
    public static string checkedYes = "y";
    public static string checkedNo = "n";
    public static string notChosenYesOrNo = "Извините, но вы не написали ни 'y' ни 'n'. Введите контректный символ. ";
}
