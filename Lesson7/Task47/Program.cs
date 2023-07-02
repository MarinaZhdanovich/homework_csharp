/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[,] Create2DArray(int rows, int columns)
{
    return new double[rows, columns];
}

void Fill2DArray(double[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++) //строки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            array[i, j] = Math.Round(rnd.NextDouble() + rnd.Next(min, max), 2);
        }
    }
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");   //пробел или табуляция \t (на каждое значение 8 символов)
        }
        Console.WriteLine();
    }
}


int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимально значение диапазона: ");

double[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);