﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] array = new int[8];

void Base(int[] value)
    {
    Console.Write("[ ");

        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
            Console.Write($"{array[i]}  ");
        }
    Console.Write("]"); 
    }

Base(array);



