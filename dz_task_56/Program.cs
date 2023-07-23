/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка. */

int[,] GetRandom2dArray(int rows, int columns, int deviation)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] FindSumOfNumber(int[,] array)
{
    int[] sumInArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumInArray[i] += array[i, j];
        }
    }
    return sumInArray;
}

int  MinSumInArray(int[] array)
{   
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= array[min])
        {
            min = i;
        } 
    }return min;
}


int[,] matrix = GetRandom2dArray(3, 5, 10);
Print2DArray(matrix);
System.Console.WriteLine();
int[] newArray = FindSumOfNumber(matrix);
System.Console.WriteLine();
int result = MinSumInArray(newArray);
System.Console.WriteLine($" Строка с наименьшей суммой чисел - {result+1}");





