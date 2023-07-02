/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void Average2DColumns(int[,] array)
{
    double average = 0;
    double sum = 0;

    for (int j = 0; j < array.GetLength(1); j++) //  для перебора каждого столбца
    {
        sum = 0;   // обнуляем сумму перед каждым столбцом
        for (int i = 0; i < array.GetLength(0); i++) // для каждой строки в текущем столбце
        {
            sum += array[i, j];
        }
        average = Math.Round(sum / array.GetLength(0), 2); // делим на количество строк
        Console.Write($"{average}; ");
    }
    
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимально значение диапазона: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);

Average2DColumns(myArray);