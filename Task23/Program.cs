/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


int GetInfo(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void Cube(int number)
{
    for (int i = 1; i <= number; i++)  // по условию от 1
    {
        Console.Write($"{Math.Pow(i, 3)}");
        if (i < number)
        {
            Console.Write(", ");
        }
    }
}


int result = GetInfo("Enter a number: ");
Cube(result);