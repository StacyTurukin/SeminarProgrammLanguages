/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


Console.WriteLine(" Пожалуйста введите 5-значное число");
int value = Convert.ToInt32(Console.ReadLine());
start:
if (value > 99999 || value < 10000)
{
    Console.WriteLine("Нужно 5-значное число");
    value = Convert.ToInt32(Console.ReadLine());
    goto start;
}


Console.WriteLine(FindPalindrome(value));

bool FindPalindrome(int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
        return true;
    return false;
}






