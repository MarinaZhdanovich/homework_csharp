/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

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
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
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


int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; // новая матрица = количеству строк в matrix1 и количеству столбцов в matrix2. 
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0; // обнуляем каждый раз
            for (int k = 0; k < matrix1.GetLength(1); k++)  
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

int rows1 = InputNum("Введите количество строк: ");
int columns1 = InputNum("Введите количество столбцов: ");
int minValue1 = InputNum("Введите минимальное значение диапазона: ");
int maxValue1 = InputNum("Введите максимально значение диапазона: ");

int[,] myArray1 = Create2DArray(rows1, columns1);
Fill2DArray(myArray1, minValue1, maxValue1);
Print2DArray(myArray1);

int rows2 = InputNum("Введите количество строк: ");
int columns2 = InputNum("Введите количество столбцов: ");
int minValue2 = InputNum("Введите минимальное значение диапазона: ");
int maxValue2 = InputNum("Введите максимально значение диапазона: ");

int[,] myArray2 = Create2DArray(rows2, columns2);
Fill2DArray(myArray2, minValue2, maxValue2);
Print2DArray(myArray2);


if (columns1 != rows2)
{
    Console.WriteLine();
    Console.WriteLine("Нельзя выполнить умножение матриц. Количество столбцов первой матрицы не равны количеству строк второй матрицы");
}
else
{
    Console.WriteLine("Результирующая матрица будет: ");
    int[,] result = MultiplicationMatrix(myArray1, myArray2);
    Print2DArray(result);
}