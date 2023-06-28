/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.WriteLine("Введдите ваше число;");
string str = Console.ReadLine();

while (str.Length <= 2 )
{
    Console.WriteLine("Третьей цифры нет,введите трехзначное или большее число:");
    str = Console.ReadLine();
}
Console.WriteLine($"Ответ: {str[2]}");

