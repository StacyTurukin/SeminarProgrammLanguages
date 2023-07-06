/*
 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


Console.WriteLine("Введите ваше число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
do
{
    sum += number % 10;
    number /= 10;
} while (number != 0);
Console.WriteLine($"Сумма цифр-{sum}");