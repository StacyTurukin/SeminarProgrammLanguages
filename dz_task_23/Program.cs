/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
int index = 1;
Console.WriteLine("Введите число:");
int value = Convert.ToInt32(Console.ReadLine());

do
{
    int result = index * index * index;
    index = index + 1;
    Console.Write(result);
    Console.Write(", ");
} while (index < value);

if (index == value)
    Console.Write(Math.Pow(value, 3));
    Console.WriteLine(".");
    