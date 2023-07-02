/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void Fill2DArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}


// void Get2DValue(int[,] array, int row, int column)
// {
//     if (row >= array.GetLength(0) || column >= array.GetLength(1))
//         Console.WriteLine("Такого числа в массиве нет!");
//     else
//         Console.WriteLine($"Позиция {row}{column} равна числу {array[row, column]}");
// }


void Get2DPosition(int[,] array, int position)
{
    int totalElements = array.GetLength(0) * array.GetLength(1); // длину строки * длину столбцов

    if (position >= 1 && position <= totalElements)
    {
        int row = (position - 1) / array.GetLength(1);  // позиция по порядку (поэтому отнимаем 1) у нас индексация с нуля // 
        int column = (position - 1) % array.GetLength(1); //делим на количество столбцов
        int value = array[row, column];
        Console.WriteLine($"Порядковый номер {position} = {value}");
    }
    else
        Console.WriteLine("Такого числа в массиве нет!");
}


int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимально значение диапазона: ");
int position = InputNum("Введите порядковый номер: ");

// int rowUser = InputNum("Введите номер строки: ");
// int columnUser = InputNum("Введите номер столбца: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);

// Get2DValue(myArray, rowUser, columnUser);
Get2DPosition(myArray, position);