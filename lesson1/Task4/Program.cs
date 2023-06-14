// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Enter a number: ");
// int number = int.Parse(Console.ReadLine()!);

// while (number > 0)
// {
//     if (number % 2 == 0)
//     {
//         Console.Write($"{number}, ");
//     }
//     number--;
// }


Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);
int count = 0; //счетчик, который отслеживает количество четных чисел, уже выведенных в цикле

while (number > 0)
{
    if (number % 2 == 0)
    {
        if (count > 0)   //если count больше нуля, мы выводим запятую и пробел перед каждым числом, кроме первого.
        {
             Console.Write(", ");
        }
        Console.Write(number);
        count++;
    }
    number--;
}




