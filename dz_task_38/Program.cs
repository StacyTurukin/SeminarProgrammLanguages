/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] FillArray(int length)
{
    double[] result = new double[length];
    double minValue = 0.0; // Минимальное значение
    double maxValue = 100.0; // Максимальное значение
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        result[i] = Math.Round(result[i], 2);
    }
    return result;
}

void printArray(double[] arrayToPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(" ,  ");
        }
    }
    Console.WriteLine("] ");
}

double[] randomArray = FillArray(5);
printArray(randomArray);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна: {randomArray.Max() - randomArray.Min()} ");


// Функция по нахождению максимума для Валерии.
/* double findMax(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
System.Console.WriteLine(findMax(randomArray));*/

