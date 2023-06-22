/* Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number * -1;
while (count <= number){
    Console.Write(count);
    Console.Write(" ");
    count++;
}