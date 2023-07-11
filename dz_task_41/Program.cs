/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

void printArray(int[] arrayToPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(",  ");
        }
    }
    Console.WriteLine("] ");
}
Console.WriteLine("Введите желаемое колл-во чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    System.Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}


printArray(array);

int count = 0;
for (int i = 0; i < M; i++)
{
    if(array[i]> 0)
    {
        count+=1;
    }
}
System.Console.WriteLine($"Кол-во положительных чисел равна: {count}" );
