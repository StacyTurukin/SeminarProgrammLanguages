/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.*/

Console.WriteLine("Введите ваше число:");
int number =Convert.ToInt32(Console.ReadLine());
int count = number % 10;
 