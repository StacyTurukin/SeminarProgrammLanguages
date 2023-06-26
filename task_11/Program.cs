/*Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.*/

int randomNumber = new Random().Next(100,1000);
Console.WriteLine($"Рандомное-{randomNumber}");

int numberOne = randomNumber % 100;
int numberTwo = randomNumber / 100;

//Console.Write(numberOne.ToString()+numberTwo.ToString());

Console.Write(numberOne);
Console.Write(numberTwo);