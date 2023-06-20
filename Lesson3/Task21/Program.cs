/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetInfo(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int xA = GetInfo("Введите x для координаты A: ");
int yA = GetInfo("Введите y для координаты A: ");
int zA = GetInfo("Введите z для координаты A: ");
int xB = GetInfo("Введите x для координаты B: ");
int yB = GetInfo("Введите y для координаты B: ");
int zB = GetInfo("Введите z для координаты B: ");

double distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double resX = Math.Pow((xB - xA), 2);
    double resY = Math.Pow((yB - yA), 2);
    double resZ = Math.Pow((zB - zA), 2);
    double result = Math.Sqrt(resX + resY + resZ);
    return result;
}

double final = distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве -> {Math.Round(final, 2)}");



    