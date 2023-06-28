/*Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 || number >= 1000)
{
    Console.Write(" Неверно, пожалуйста ведите ТРЁХЗНАЧНОЕ число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int okay = number / 10 % 10;
Console.WriteLine($"Ваше число - {number}");
Console.WriteLine($"Ответ: {okay}");
