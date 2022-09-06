namespace MyLibrary;

/// <summary>
/// статичные переменные с текстом сообщений для вывода в UI
/// </summary>
public static class Message
{
    /// <summary>
    /// Сообщение о некорректном вводе числа.
    /// </summary>
    public static string incorrect_input_msg = "Некорректный ввод. Повторите попытку ввода целого числа: ";
    /// <summary>
    /// Сообщение-приглашение к вводу целого числа.
    /// </summary>
    public static string invite_to_input_number_msg = "Введите целое число: ";
    /// <summary>
    /// Сообщение-приглашение к вводу номера задачи.
    /// </summary>
    public static string invite_to_input_hometask_number_msg = "Введите номер задачи: ";
    /// <summary>
    /// Сообщение об отсутствующей задаче по указанному номеру.
    /// </summary>
    public static string not_actual_task_number_msg = "Такой номер задачи отсутствует в актуальном задании. \nНомера актуальных задач описаны в 'README.md' ";
    /// <summary>
    /// Сообщение-приветствие пользователя.
    /// </summary>
    public static string welcome_msg = "Добро пожаловать в мою программу по домашним заданиям. \nНомера актуальных задач описаны в 'README.md'";
    /// <summary>
    /// Сообщение-вопрос о необходимости выполнении других задач.
    /// </summary>
    public static string ask_to_continue_msg = "Хотите ли Вы продолжить работу с другими задачами? y/n ";
    /// <summary>
    /// Сообщение-вопрос о необходимости повторения текущей задачи.
    /// </summary>
    public static string ask_to_repeat_task_msg = "Повторить выполнение этой задачи? y/n ";
    /// <summary>
    /// Сообщение-прощание с пользователем.
    /// </summary>
    public static string goodBye_msg = "Программа проверки ДЗ завершена. Спасибо за внимание.";
    /// <summary>
    /// Символ 'y' для проверки утвердительного ввода пользователя. 
    /// </summary>
    public static string checkedYes = "y";
    /// <summary>
    /// Символ 'n' для проверки отрицательного ввода пользователя. 
    /// </summary>
    public static string checkedNo = "n";
    /// <summary>
    /// Сообщение о некорректном вводе 'y' или 'n'.
    /// </summary>
    public static string not_chosen_yes_or_no_msg = "Некорретный ввод. Введите y или n: ";
}
