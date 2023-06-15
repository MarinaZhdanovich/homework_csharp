/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int GetInformation()
{
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}


void Days (int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"{number} -> да");
    }
    else if (number < 1 || number > 7)
    {
        Console.WriteLine("The wrong number");
    }
    else
    {
        Console.WriteLine($"{number} -> нет");
    }
}

int result = GetInformation();
Days(result);