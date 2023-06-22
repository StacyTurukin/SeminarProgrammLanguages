/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.*/

Console.WriteLine("Введите ваше число:");

int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if ( number < 100 || number > 999) Console.WriteLine("Нужно трехзначное число!");
else {
    count = number % 10;
Console.WriteLine(count);
}

 