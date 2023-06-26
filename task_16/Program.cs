/* Напишите программу, которая принимает на вход два 
числа и проверяет, является ли одно число квадратом другого.*/

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA * numberA == numberB || numberB * numberB == numberA)
    Console.WriteLine("True");
else
{
    Console.WriteLine("False");
}
