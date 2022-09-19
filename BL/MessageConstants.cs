namespace EKozlov.HomeWork.BL;

/// <summary>
/// Константы с текстом сообщений для вывода в UI.
/// </summary>
public static class MessageConstants
{
    /// <summary>
    /// Сообщение о некорректном вводе числа.
    /// </summary>
    public const string InvalidInput = "Некорректный ввод. Повторите попытку ввода целого числа: ";
    /// <summary>
    /// Сообщение-приглашение к вводу целого числа.
    /// </summary>
    public const string InviteInputNumber = "Введите  целое число: ";
    /// <summary>
    /// Сообщение-приглашение к вводу номера задачи.
    /// </summary>
    public const string InviteInputTask = "Введите номер задачи: ";
    /// <summary>
    /// Сообщение об отсутствующей задаче по указанному номеру.
    /// </summary>
    public const string InvalidTaskNumber = " - такой номер задачи отсутствует в списке домашних заданий. \nНомера актуальных задач описаны в 'README.md' ";
    /// <summary>
    /// Сообщение-приветствие пользователя.
    /// </summary>
    public const string Welcome = "Добро пожаловать в мою программу по домашним заданиям. \nНомера актуальных задач описаны в 'README.md'";
    /// <summary>
    /// Сообщение-вопрос о необходимости выполнении других задач.
    /// </summary>
    public const string AskContinue = "Хотите ли Вы продолжить работу с другими задачами? y/n ";
    /// <summary>
    /// Сообщение-вопрос о необходимости повторения текущей задачи.
    /// </summary>
    public const string AskRepeat = "Повторить выполнение этой задачи? y/n ";
    /// <summary>
    /// Сообщение-прощание с пользователем.
    /// </summary>
    public static string GoodBye = "Программа проверки ДЗ завершена. Спасибо за внимание.";
    /// <summary>
    /// Символ 'y' для проверки утвердительного ввода пользователя. 
    /// </summary>
    public static string CheckYes = "y";
    /// <summary>
    /// Символ 'n' для проверки отрицательного ввода пользователя. 
    /// </summary>
    public static string CheckNo = "n";
    /// <summary>
    /// Сообщение о некорректном вводе 'y' или 'n'.
    /// </summary>
    public static string NotYesOrNo = "Некорретный ввод. Введите y или n: ";
}
