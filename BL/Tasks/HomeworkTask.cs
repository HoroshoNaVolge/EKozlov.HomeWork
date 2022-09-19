
/// <summary>
/// Абстрактный родительский класс задачи.
/// </summary>
namespace EKozlov.HomeWork.BL;
public abstract class HomeworkTask
{
    protected readonly Random random;

    #region Свойства родительского класса
    /// <summary>
    /// Номер задачи согласно списку ДЗ.
    /// </summary>
    public int Number { get; protected set; }
    /// <summary>
    /// Описание (текст) задачи.
    /// </summary>
    /// <value></value>
    public string Description { get; protected set; }
    /// <summary>
    /// Массив аргументов (целых чисел) для выполнения задачи.
    /// </summary>
    /// <value></value>
    public int[] Arguments { get; set; }
    /// <summary>
    /// Количество аргументов для задачи.
    /// </summary>
    /// <value></value>
    public int QuantityOfArguments { get; protected set; }

    /// <summary>
    /// Необходимо ли деление аргументов на группы.
    /// </summary>
    /// <value></value>
    public bool GroupedArguemnts { get; protected set; }

    /// <summary>
    /// Необходимо ли определённое название вводимых аргументов.
    /// </summary>
    public string[] SpecifiedArgumentsNames { get; protected set; }

    /// <summary>
    /// Результат выполнения задачи.
    /// </summary>
    /// <value></value>
    public string Result { get; protected set; }

    #endregion

    #region Конструктор родительского типа
    /// <summary>
    /// Конструктор класса задачи.
    /// </summary>
    public HomeworkTask()
    {
        Result = string.Empty;
        Arguments = Array.Empty<int>();
        Description = string.Empty;
    }

    /// <summary>
    /// Перегруженный конструктор для задач без ввода пользователя аргументов (использование Random).
    /// </summary>
    /// <param name="withoutInputArgs"> Нужен ли ввод аргументов для задачи пользователем.</param>
    public HomeworkTask(bool withoutInputArgs)
    {
        if (withoutInputArgs) random = new Random();
    }

    #endregion

    #region Методы родительского класса 
    /// <summary>
    /// Метод выполнения решения задачи.
    /// </summary>
    public abstract void Execute();

    /// <summary>
    /// Возвращает текст с элементами массива или коллекции через запятую.
    /// </summary>
    /// <param name="intSequence">Массив или коллекция для преобразования элементов в строку.</param>
    /// <returns></returns>
    protected string GetSequenceInText(IEnumerable<int> intSequence)
    {
        string textResult = string.Empty;

        for (var i = 0; i < intSequence.Count(); i++)
            textResult += i != intSequence.Count() - 1 ? intSequence.ElementAt(i) + ", " : intSequence.ElementAt(i);

        return textResult;
    }

    /// <summary>
    /// Возвращает текст с элементами массива или коллекции через запятую.
    /// </summary>
    /// <param name="doubleSequence">Массив или коллекция для преобразования элементов в строку.</param>
    /// <returns></returns>
    protected string GetSequenceInText(IEnumerable<double> doubleSequence)
    {
        string textResult = string.Empty;
        string tempValue;

        for (var i = 0; i < doubleSequence.Count(); i++)
        {
            tempValue = Math.Round(doubleSequence.ElementAt(i), 2).ToString().Replace(',', '.');

            textResult += i != doubleSequence.Count() - 1 ? tempValue + ", " : tempValue;
        }
        return textResult;
    }

    #endregion
}
