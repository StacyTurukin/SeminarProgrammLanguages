/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


Console.WriteLine("ВВедите число:");
int number = Convert.ToInt32(Console.ReadLine());

while ( number < 1 || number > 7 )
{
    Console.WriteLine("Введите число от 1 до 7");
    number = Convert.ToInt32(Console.ReadLine());
}

if (number > 5 && number <= 7)
{
    Console.WriteLine("Выходной");
}
else 
    Console.WriteLine("К сожалению, нужно трудиться");
