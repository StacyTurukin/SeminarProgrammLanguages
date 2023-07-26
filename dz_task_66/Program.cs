/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumOfNum(int M, int N)
{
    if (M == N) return M;
    return M + SumOfNum(M + 1, N);
}
int result = SumOfNum(1, 15);
System.Console.WriteLine(result);