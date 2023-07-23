/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] matrixA = GetRandom2dArray(2, 3, 5);
int[,] matrixB = GetRandom2dArray(3, 2, 5);
Print2DArray(matrixA);
System.Console.WriteLine();
Print2DArray(matrixB);
System.Console.WriteLine();
int[,] multiplicationResult = matrixMultiplication(matrixA, matrixB);
if (multiplicationResult == null)
{
    System.Console.WriteLine("Матрицы нельзя умножать!");
}
else
{
    Print2DArray(multiplicationResult);
}
//Print2DArray(matrixMultiplication(matrixA, matrixB));



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

int[,] matrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
        return null;

    int[,] multiplicationResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiplicationResult[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multiplicationResult;

}


