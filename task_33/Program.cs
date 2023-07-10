/* Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.*/

int[] FillArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}

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

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] randomArray = FillArray(10, 9);
printArray(randomArray);


bool isNumberInArray(int[] randomArray, int value)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (value == randomArray[i])
        return true;
    } return false;
}

// System.Console.WriteLine(isNumberInArray(randomArray, num)); - вывод true\false
if(isNumberInArray(randomArray,num))
System.Console.WriteLine("ДА");
else System.Console.WriteLine("НЕТ");