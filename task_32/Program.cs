// Напишите программу замены элементов массива: положительные на отрицательные и наоборот.

int[] FillArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    printArray(result);
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

void NegToPos(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++) 
    {
        numbers[i] *= -1;
    }
}

int[]numsArray= FillArray(15,10);
NegToPos(numsArray);
printArray(numsArray);
