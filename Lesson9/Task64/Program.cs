/* 
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(--start, end));
// }

// int num = InputNum("Введите целое число: ");
// Console.WriteLine(PrintNumbers(num, 1));


void PrintNumbers(int start, int end)
{
    if (start < end) return;  // return выход из функции без возврата значения, поэтому start < end, а не ==
    Console.Write(start + " ");
    PrintNumbers(--start, end);   //--start уменьшаем на 1 перед вызовом функции (в рекурсии без разницы --start или start - 1)
}

int num = InputNum("Введите целое число: ");
PrintNumbers(num, 1);



// int start = 5;
// int result1 = --start;    //сначала уменьшение значения, затем ПРИСВАИВАНИЕ - это важно (start = 4)
// int result2 = start - 1;     // в start уже 4, так как выше изменилась переменная, просто вычитание 

// Console.WriteLine(result1);  // вывод 4
// Console.WriteLine(result2);  // вывод 3


// int start = 5;
// int result1 = start - 1;    // start не меняется = 5-1
// int result2 = start - 1;     // start не меняется = 5-1

// Console.WriteLine(result1);  // вывод 4
// Console.WriteLine(result2);  // вывод 4