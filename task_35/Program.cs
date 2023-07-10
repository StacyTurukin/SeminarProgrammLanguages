/* Задайте одномерный массив из 123 случайных чисел. Найдите колличество элементов массива,
значения которых лежат в отрезке [10,99].*/


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

/* МОЁ Решение
int[] randomArray = FillArray(123, 1000);
printArray(randomArray);

int sumOfNumInArray(int[] randomArray)
{
    int sum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] > 10 && randomArray[i] < 100)
        sum+=1;
    } return sum;
}
int sumNumbers = sumOfNumInArray(randomArray);
System.Console.WriteLine(sumNumbers);*/

// Решение в классе:

int fillNumberArray(int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end)
            count += 1;
    }
    return count;
}

int[] randomArray = FillArray(123, 1000);
printArray(randomArray);

int sumNumbers = (fillNumberArray(randomArray, 10, 99));
System.Console.WriteLine(sumNumbers);