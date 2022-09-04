# Козлов Е.А. C#. ДЗ к семинарам.

Актуальное непроверенное ДЗ - СЕМИНАР 2:  задачи №10 , №13, №15.

## Список задач: 
### Семинар №2 (<span style ="color:#228b22	"> **Актуально для проверки**</span> )

*  **Задача 10**:.</span>  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

* **Задача 13**: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

* **Задача 15**: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
###  <span style ="color:#696969"> **Семинар №1 (Проверено)** 
* <span style ="color:#696969"> Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
* <span style ="color:#696969"> Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
* <span style ="color:#696969"> Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).** 
* <span style ="color:#696969"> Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 

## Описание программы:
Структура программы усложнена для возможности дальнейшего расширения и использования в обучении, а также для возможности потенциальной замены UI с консоли на что-то поинтереснее.

1. Реализация логики конкретной задачи описана в конкретных классах TaskN, где N - номер конкретной задачи из домашнего задания.
2. Добавление новой задачи в программу выполняется путём добавления нового класса TaskN : HomeworkTask (например class Task5:HomeworkTask), в методе Execute которого описывается реализация задачи.
3. Связывание кода с новым классом конкретной задачи выполняется путём добавления номера задачи в метод TaskCreator.CreateTask в блок switch по её номеру (например switch 5: return new Task5()).
4. Создание экземляра новой задачи реализовано через класс TaskCreator.
Точка входа в программу в Program.cs
