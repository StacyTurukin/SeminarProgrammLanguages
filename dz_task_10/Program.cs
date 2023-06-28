/*Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/


int Base(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    while (result < 100 || result >= 1000)
    {
        Console.Write(message);
        result = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}
int number = Base("Введите трёхзначное число: ");
Console.WriteLine($"Введенное число - {number}");
int okay = number / 10 % 10;
Console.WriteLine($"Вторая цифра - {okay}");