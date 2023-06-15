/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int GetInformation()
{
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void GetThird(int number)
{
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        while (number > 999)
        {
            number = number / 10; //число делится на 10 до тех пор, пока оно больше 999. Отбрасываем все цифры числа, кроме последних трех.
        }
        int third = number % 10;

        Console.WriteLine($" -> {third}");
    }

}

int num = GetInformation();
GetThird(num);