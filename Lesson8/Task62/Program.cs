/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

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

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int[,] myArray = Create2DArray(rows, columns);

if (rows != columns)
{
    Console.WriteLine();
    Console.WriteLine("Нельзя заполнить этот массив спирально. Количество строк не равны количеству столбцов");
}
else
{
    FillArray(myArray);
    PrintArray(myArray);
}