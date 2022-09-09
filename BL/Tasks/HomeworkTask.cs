/// <summary>
/// Абстрактный родительский класс задачи.
/// </summary>
namespace EKozlov.HomeWork.BL;
public abstract class HomeworkTask
{
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
    public bool GroupedArguemnts{get; protected set;}
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

    #endregion

    #region Методы родительского класса 
    /// <summary>
    /// Метод выполнения решения задачи.
    /// </summary>
    public abstract void Execute();

    #endregion
}