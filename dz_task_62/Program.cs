/* Задача 62. Напишите программу, которая заполнит 
спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] CreateSpiraldArray(int rows, int columns)
{
    int[,] spiralArray = new int[rows, columns];
    int value = 0;
    int rowStart = 0;
    int rowEnd = 3;
    int columnStart = 0;
    int columnEnd = 3;
    while (rowStart <= rowEnd && columnStart <= columnEnd)
    {
        for (int i = columnStart; i <= columnEnd; i++)
        {
            spiralArray[rowStart, i] = value++;
        }
        rowStart++;
        for (int i = rowStart; i <= rowEnd; i++)
        {
            spiralArray[i, columnEnd] = value++;
        }
        columnEnd--;
        if (rowStart <= rowEnd)
        {
            for (int i = columnEnd; i >= columnStart; i--)
            {
                spiralArray[rowEnd, i] = value++;
            }
            rowEnd--;
        }
        if (columnStart <= columnEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                spiralArray[i, columnStart] = value++;
            }
            columnStart++;
        }
    }
    return spiralArray;
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
int[,] doneSpiralArray = CreateSpiraldArray(4,4);
Print2DArray(doneSpiralArray);