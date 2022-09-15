
/// <summary>
/// Абстрактный родительский класс задачи.
/// </summary>
namespace EKozlov.HomeWork.BL;
public abstract class HomeworkTask
{
    protected Random random; // переменная для работы с рандомом в классах-наследниках.

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
    public int QuantityOfArguments { get; protected set; } // свойство, содержащее количество аргументов для задачи

    /// <summary>
    /// Необходимо ли деление аргументов на ггруппы.
    /// </summary>
    /// <value></value>
    public bool GroupedArguemnts { get; protected set; }

    /// <summary>
    /// Результат выполнения задачи.
    /// </summary>
    /// <value></value>
    public string Result { get; protected set; } // свойство с результатом выполнения задачи

    #endregion

    #region Конструктор родительского типа
    /// <summary>
    /// Конструктор класса задачи.
    /// </summary>
    public HomeworkTask()
    {
        Result = string.Empty; // для исключения null-reference
        Arguments = Array.Empty<int>(); // для исключения null-reference
        Description = string.Empty; // для исключения null-reference
    }

    /// <summary>
    /// Перегруженный конструктор для задач без ввода пользователя аргументов.
    /// </summary>
    /// <param name="withoutInputArgs"> Нужен ли ввод аргументов для задачи пользователем.</param>
    public HomeworkTask(bool withoutInputArgs)
    {
        if (withoutInputArgs) random = new Random(); // если не нужен, создаём рандом для генерации случайных чисел, массивов и прочего.
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

            textResult += i != doubleSequence.Count() - 1 ? tempValue + ", " : tempValue; // меняет запятую на точку в отображении числа для исключения путаницы - в нашей строке элементы разделяются запятой.
        }
        return textResult;
    }

    #endregion
}
