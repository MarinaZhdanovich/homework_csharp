/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int GetNaturalDegree(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

bool ValidateNumberB(int numberB)
{
    if (numberB <= 0)
    {
        Console.WriteLine("The number must be greater than zero");
        return false;
    }
    else
        return true;
}

int numA = InputNum("Enter the number A: ");
int numB = InputNum("Enter the number B: ");

int final = GetNaturalDegree(numA, numB);
if (ValidateNumberB(numB))
{
    Console.WriteLine($"{numA}, {numB} -> {final}");
}