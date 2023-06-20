/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int InputNum(string message)
{
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GetSumOfNumbers(int number)
{
    int result = 0;
    for (int i = 0; number > 0; i++)
    {
        int remaider = number % 10;  // или result += number %10
        result = result + remaider;
        number /= 10;
    }
    return result;
}

int num = InputNum("Enter a number: ");
int final = GetSumOfNumbers(num);
Console.WriteLine($"{num} -> {final}");

