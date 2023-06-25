/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 200 - 100; //0 * 200 - 100 = -100; 1 * 200 - 100 = 100, диапазон от [-100, 100)
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        double final = Math.Round(array[i], 2);
        Console.Write(final + " ");
    }
    Console.WriteLine();
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}


int size = InputNum("Enter a size of the array: ");
double[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);

double max = GetMax(myArray);
Console.WriteLine($"max = {Math.Round(max, 2)}");

double min = GetMin(myArray);
Console.WriteLine($"min = {Math.Round(min, 2)}");

Console.WriteLine($"max - min =  {Math.Round(max - min, 2)}");