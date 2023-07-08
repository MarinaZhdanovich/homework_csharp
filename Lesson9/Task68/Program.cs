/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

int m = InputNum("Введите целое число M: ");
int n = InputNum("Введите целое число N: ");
int result = Ackermann(m, n);
Console.WriteLine(result);


//Функция Аккермана – это математическая функция, которая определяется рекурсивно и используется для изучения роста функций в теории вычислимости и математической логике.
//Главной особенностью функции Аккермана является ее быстрый рост.