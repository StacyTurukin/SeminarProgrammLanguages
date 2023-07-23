/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int [] newArray = UnUsedNumbers(90);    
int[] UnUsedNumbers(int arraySize)
{
    int[] unUsedNumbers = new int[arraySize];
    for (int i = 0; i < unUsedNumbers.Length; i++)
    {
        int num;
        do
        {
            num = new Random().Next(10, 100);
        } while(Array.IndexOf(unUsedNumbers,num)!=-1);
        unUsedNumbers[i]=num;
    } return unUsedNumbers;
} 

int[,,] GetRandom2dArray(int length, int height, int width)
{
    int[,,] result = new int[length, height, width];
    int randomIndex=0;
    for (int i = 0; i < length; i++)
    {
        for (int j=0 ; j < height; j++)
        {
            for (int k = 0; k < width; k++)
            {
                result[i,j,k]= newArray[randomIndex];
                randomIndex++;
            }
        }
    }
    return result;
}

void Print2DArray(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.Write($"{arrayToPrint[i, j, k]} ({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] matrix = GetRandom2dArray(4, 4, 4);
Print2DArray(matrix);
System.Console.WriteLine();


/* Чисто для проверки вывода неиспользуемых значений. 
PrintArray(newArray); 
 void PrintArray(int[] array)
{
    for ( int i =0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} , ");
    }
}
  */