/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int size1, int size2, int size3)
{
    return new int[size1, size2, size3];
}

void Fill3DArray(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int number = rnd.Next(10, 100); // генерируем случайное число
                while (NumInArray(array, number)) // пока массив содержит дубль сгенерированного числа
                {
                    number = rnd.Next(10, 100); // генерируем новое число
                }
                array[i, j, k] = number;  // уникальное число
            }
        }
    }
}


bool NumInArray(int[,,] array, int number) // проверка наличия числа в массиве
{
    foreach (int item in array)
    {
        if (item == number)
            return true;
    }
    return false;
}


void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

int size1 = InputNum("Введите размер size1: ");
int size2 = InputNum("Введите размер size2: ");
int size3 = InputNum("Введите размер size3: ");

int[,,] myArray = Create3DArray(size1, size2, size3);
Fill3DArray(myArray);
Print3DArray(myArray);