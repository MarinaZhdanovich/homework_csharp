/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size) // после метода(функции) не нужна ";"
{
    return new int[size];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i] + " ";  // result = result + array[i] + " "
    }
    return result;
}

int NumberOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}

int size = InputNum("Enter a size of the array: ");

int[] myArray = CreateArray(size);
FillArray(myArray);
string text = PrintArray(myArray);
Console.WriteLine(text);

int result = NumberOfEven(myArray);
Console.WriteLine($"-> {result}");