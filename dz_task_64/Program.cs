/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void NaturalNumbers(int value, int count = 1)
{
    if (value < count)
        return;
    else
    {
        Console.Write(value + " ");
        NaturalNumbers(value - 1, count);
    }
}
NaturalNumbers(8);