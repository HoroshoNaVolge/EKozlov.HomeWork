namespace MyLibrary;

/// <summary>
/// Константы с текстом сообщений для вывода в UI.
/// </summary>
public static class Message
{
    /// <summary>
    /// Сообщение о некорректном вводе числа.
    /// </summary>
    public const string INVALID_INPUT_MSG = "Некорректный ввод. Повторите попытку ввода целого числа: ";
    /// <summary>
    /// Сообщение-приглашение к вводу целого числа.
    /// </summary>
    public const string INVITE_TO_INPUT_NUMBER_MSG = "Введите целое число: ";
    /// <summary>
    /// Сообщение-приглашение к вводу номера задачи.
    /// </summary>
    public const string INVITE_TO_INPUT_TASK_NUMBER_MSG = "Введите номер задачи: ";
    /// <summary>
    /// Сообщение об отсутствующей задаче по указанному номеру.
    /// </summary>
    public const string INVALID_TASK_NUMBER_MSG = "Такой номер задачи отсутствует в актуальном задании. \nНомера актуальных задач описаны в 'README.md' ";
    /// <summary>
    /// Сообщение-приветствие пользователя.
    /// </summary>
    public const string WELCOME_MSG = "Добро пожаловать в мою программу по домашним заданиям. \nНомера актуальных задач описаны в 'README.md'";
    /// <summary>
    /// Сообщение-вопрос о необходимости выполнении других задач.
    /// </summary>
    public const string ASK_TO_CONTINUE_MSG = "Хотите ли Вы продолжить работу с другими задачами? y/n ";
    /// <summary>
    /// Сообщение-вопрос о необходимости повторения текущей задачи.
    /// </summary>
    public const string ASK_TO_REPEAT_TASK_MSG = "Повторить выполнение этой задачи? y/n ";
    /// <summary>
    /// Сообщение-прощание с пользователем.
    /// </summary>
    public static string GOODBYE_MSG = "Программа проверки ДЗ завершена. Спасибо за внимание.";
    /// <summary>
    /// Символ 'y' для проверки утвердительного ввода пользователя. 
    /// </summary>
    public static string CHECKED_YES = "y";
    /// <summary>
    /// Символ 'n' для проверки отрицательного ввода пользователя. 
    /// </summary>
    public static string CHECKED_NO = "n";
    /// <summary>
    /// Сообщение о некорректном вводе 'y' или 'n'.
    /// </summary>
    public static string NOT_CHOSEN_YES_OR_NO_MSG = "Некорретный ввод. Введите y или n: ";
}
