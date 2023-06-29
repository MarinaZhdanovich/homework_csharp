/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

/* 1)
string InputNum(string message)
{
    Console.Write(message);
    return (Console.ReadLine()!);
}

int CountPositiveNumbers(string numbers)
{
    int count = 0;
    {
        string[] arrayString = numbers.Split(",");  // разделяем строки на подстроки, используя запятую в качестве разделителя
        int[] arrayNumber = Array.ConvertAll(arrayString, int.Parse); //массив строк преобразуем в массив целых чисел

        foreach (int item in arrayNumber)  // foreach только для чтения
        {
            if (item > 0) count++;
        }
    }
    return count;
}

string myNumbers = InputNum("Enter numbers separated by commas: ");
int result = CountPositiveNumbers(myNumbers);
Console.WriteLine($"Count of positive numbers -> {result}");
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int CountPositiveNumbers(int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        int number = InputNum("Enter a number: ");
        if (number > 0)
            count++;
    }
    return count;
}

int size = InputNum("Enter a count of numbers: ");
int result = CountPositiveNumbers(size);
Console.WriteLine($"Count of positive numbers -> {result}");