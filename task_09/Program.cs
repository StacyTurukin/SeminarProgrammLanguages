/*Напишите программу, которая выводит случайное 
число из отрезка [10, 99] и показывает наибольшую цифру числа*/

int randomNumber = new Random().Next(10,100);
Console.WriteLine($"Рандомное число-{randomNumber}");

int numberOne = randomNumber % 10;
int numberTwo = randomNumber / 10;

if (numberOne > numberTwo) 
{
    Console.WriteLine(numberOne);
}
else 
{
    Console.WriteLine(numberTwo);
}

