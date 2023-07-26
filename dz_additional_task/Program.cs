/* Доп
Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26 */

void SumOfNumbers(int number1, int number2, int N)
{
    if(N > 0)
    {
        Console.Write(number1 + " ");
        int temp = number2;
        number2 = number1 + number2;
        number1 = temp;
        SumOfNumbers(number1, number2, N - 1);
    }
}

SumOfNumbers(6, 10, 4);

