/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int InputNum(string message)
{
    Console.Write("Enter a number: ");
    return int.Parse(Console.ReadLine()!);
}

int[] ArrayRand(int size)
{
    int[] array = new int[size];   //создается новый массив размера size 
    for (int i = 0; i < array.Length; i++)
    {        
        array[i] = new Random().Next(0, 100); //заполняем массив случайными числами
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
       Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length -1]}]");
}


int num = InputNum("Enter a number: ");
int[] arr = ArrayRand(num);
PrintArray(arr);



