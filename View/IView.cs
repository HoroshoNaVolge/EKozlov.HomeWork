public interface IView
{
    /// <summary>
    /// Метод ввода 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public int GetIntegerInput(string message);

    public bool GetYesOrNoInput(string message);

    public void ShowMessage(string message);

    public delegate void MessageHandler(string msg);

    /// <summary>
    /// Делегат ввода данных из UI. Возвращает INT.
    /// </summary>
    /// <param name="msg">Сообщение для вывода в UI.</param>
    public delegate int InputHandler(string msg);

    /// <summary>
    /// Делегат ввода 'да' или 'нет' из UI.
    /// </summary>
    /// <param name="msg">Сообщение для вывода в UI.</param>
    public delegate bool YesOrNoInputHandler(string msg);

    /// <summary>
    /// Метод консольного вывода сообщений.
    /// </summary>
    /// <param name="msg">Сообщение для вывода.</param>
}

