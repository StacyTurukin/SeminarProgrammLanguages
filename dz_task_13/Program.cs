/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.WriteLine("Введдите ваше число;");
string str = Console.ReadLine();
//int n = str[2];
if (str.Length > 2 )
    Console.WriteLine(str[2]);
else 
    Console.WriteLine("Третьей цифры нет");
