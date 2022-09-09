namespace EKozlov.HomeWork.View;
using static EKozlov.HomeWork.BL.MessageConstants;

/// <summary>
/// Обёртка для типа System.Console
/// </summary>
public class Console_UI : IView
{
    /// <summary>
    /// Метод ввода через консоль. Возвращает int после проверок и преобразования.
    /// </summary>
    /// <param name="message">Cообщение для вывода в консоль. </param>
    public int GetIntegerInput(string message)
    {
        string consoleInput = ReadLine(message); //  Кладём в переменную вводенные данные с консоли. Используем MyConsole для возможности одновременно использовать Console. Write

        if (int.TryParse(consoleInput, out var parseResult)) // Проверка на допустимость преобразования введенных символов в тип int.  
            return parseResult; // преобразование возможно - возвращаем int 
        else
            return GetIntegerInput(INVALID_INPUT_MSG); // преобразование невозможно - рекурсивно вызываем метод ввода, пока не будет корректного ввода
    }

    /// <summary>
    /// Метод получения через консоль утвердительного или отрицательного ввода: 'y' или 'n'.
    /// </summary>
    /// <param name="message"> Вывод в консоль комментария. </param>
    public bool GetYesOrNoInput(string message)
    {
        string stringInput = ReadLine(message);
        if (stringInput?.ToLower() == CHECKED_YES) // если ввод "y/Y" - продолжаем
        {
            return true;
        }
        else if (stringInput?.ToLower() == CHECKED_NO) // если ввод "n/N" - завершаем.
        {
            return false;
        }

        else // если введен другой символ/символы
        {
            return GetYesOrNoInput(NOT_CHOSEN_YES_OR_NO_MSG); // рекурсивный вызов ввода y или n
        }
    }

    public void ShowMessage(string message) => System.Console.WriteLine(message);


    /// <summary>
    /// Перегруженный метод с аргументом для вывода в консоль одновременно с запросом ввода пользователя 
    /// </summary>
    /// <param name="message"> Сообщение для вывода в консоль.</param>
    /// <returns></returns>
    public static string ReadLine(string message)  // Допускаем NULL при помощи <string?>.
    {
        System.Console.Write(message); // Выдаем сообщение в консоль. 
        return System.Console.ReadLine(); // Запрос ввода пользователя в консоль.
    }

}
