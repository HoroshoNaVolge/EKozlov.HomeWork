namespace EKozlov.HomeWork.View;
public interface IView
{
    /// <summary>
    /// Вывод сообщения в UI.
    /// </summary>
    /// <param name="message">Сообщение для вывода.</param>
    public void ShowMessage(string message);

    /// <summary>
    /// Ввод пользователем целого числа в UI.
    /// </summary>
    /// <param name="message">Сообщение для вывода в UI.</param>
    /// <returns> int после parse().</returns>
    public int GetIntegerInput(string message);

    /// <summary>
    /// Получение от пользователя "да" или "нет"
    /// </summary>
    /// <param name="message">Сообщение для вывода в UI.</param>
    /// <returns>true, если "да".</returns>
    public bool GetYesOrNoInput(string message);


    /// <summary>
    /// Делегат вывода сообщения в UI.
    /// </summary>
    /// <param name="msg">Сообщение для вывода в UI.</param>
    public delegate void MessageHandler(string msg);

    /// <summary>
    /// Делегат ввода пользователем целого числа в UI.
    /// </summary>
    /// <param name="message">Сообщение для вывода в UI.</param>
    /// <returns> int после parse().</returns>
    public delegate int InputHandler(string msg);

    /// <summary>
    /// Делегат получения ввода пользователеем "да" или "нет"
    /// </summary>
    /// <param name="message">Сообщение для вывода в UI.</param>
    /// <returns>true, если "да".</returns>
    public delegate bool YesOrNoInputHandler(string msg);
}

