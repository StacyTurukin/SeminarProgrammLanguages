﻿/*Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.*/

Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber % secondNumber;

if (result == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine(result);
}
