/* Напишите программу, которая принимает на вход 
число и проверяет, кратно ли оно одновременно 7 и 23.*/

Console.WriteLine("Введите ваше число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

if (firstNumber % a == 0 && firstNumber % b == 0)
    Console.WriteLine("true");
else
    Console.WriteLine("false");
