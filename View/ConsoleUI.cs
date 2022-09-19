namespace EKozlov.HomeWork.View;
using static EKozlov.HomeWork.BL.MessageConstants;

/// <summary>
/// Консольный UI.
/// </summary>
public class ConsoleUI : IView
{
    /// <summary>
    /// Метод ввода через консоль. Возвращает int после проверок и преобразования.
    /// </summary>
    /// <param name="message">Cообщение для вывода в консоль. </param>
    public int GetIntegerInput(string message)
    {
        string consoleInput = ReadLine(message);

        if (int.TryParse(consoleInput, out var parseResult))
            return parseResult;
        else
            return GetIntegerInput(InvalidInput);
    }

    /// <summary>
    /// Метод получения через консоль утвердительного или отрицательного ввода: 'y' или 'n'.
    /// </summary>
    /// <param name="message"> Вывод в консоль комментария. </param>
    public bool GetYesOrNoInput(string message)
    {
        string stringInput = ReadLine(message);

        if (stringInput.ToLower() == CheckYes)
            return true;

        else if (stringInput.ToLower() == CheckNo)
            return false;

        else
            return GetYesOrNoInput(NotYesOrNo);
    }

    /// <summary>
    /// Метод вывода сообщений в консоль.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    public void ShowMessage(string message) => Console.WriteLine(message);

    /// <summary>
    /// Перегруженный метод с аргументом для вывода в консоль одновременно с запросом ввода пользователя.
    /// </summary>
    /// <param name="message"> Сообщение для вывода в консоль.</param>
    /// <returns></returns>
    public static string ReadLine(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    /// <summary>
    /// Очистка консоли.
    /// </summary>
    public void Clear() => Console.Clear();
}
