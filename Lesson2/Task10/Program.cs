/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int GetInformation()
{ Console.Write("Enter a three-digit number: ");
    int number = int.Parse(Console.ReadLine()!);
    if (number < 100 || number > 1000)
    {
        Console.WriteLine("Your number is wrong. Enter a three-digit number: ");
        number = int.Parse(Console.ReadLine()!);
        return number;
    }
    else
        return number;
}

void SecondNumber(int number)
{
    int second = number % 100;
    int result = second / 10;
    Console.WriteLine($" {number} -> {result}");
}
 
int num = GetInformation();
SecondNumber(num);