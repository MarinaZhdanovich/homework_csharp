﻿/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] array = new int[4, 4];

void FillArray(int[,] array)
{
    int value = 1;
    int i = 0;
    int j = 0;

    while (value <= array.Length)   // общее количество элементов в массиве(array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1) //  верхняя граница
            j++; // движения вправо
        else if (i < j && i + j >= array.GetLength(0) - 1) // правая граница
            i++; //движения вниз
        else if (i >= j && i + j > array.GetLength(1) - 1) // нижняя граница
            j--;  // движения влево
        else  // левая граница
            i--; // движение вверx
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);