/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double InputNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

void IntersectionPoint(double b1, double b2, double k1, double k2)
{
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают.");
    else if (k1 == k2)
        Console.WriteLine("Прямые параллельные.");
    else
    {                                                   
        double x = (b2 - b1) / (k1 - k2);  
        double y = k1 * x + b1;           
        Console.WriteLine($"x = {x}, y = {y}");
    }
}
double numB1 = InputNum("Enter value of b1: ");
double numB2 = InputNum("Enter value of b2: ");
double numK1 = InputNum("Enter value of k1: ");
double numK2 = InputNum("Enter value of k2: ");
IntersectionPoint(numB1, numB2, numK1, numK2);