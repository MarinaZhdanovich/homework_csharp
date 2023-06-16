/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetInformation(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine()!);
    return number;
}

void Palindrome(int number)
{
    int temporary = number;  //для выполнения вычислений, чтобы не изменять исходное число number.
    int reverse = 0;     //для построения перевернутого числа

    while (temporary != 0)  
    {
        int remainder = temporary % 10;  // последняя цифра числа 
        reverse = reverse * 10 + remainder; 
        temporary = temporary / 10; // удаляем последнюю цифру (или temporary /= 10 деление с присваиванием)
    }

    if (number == reverse)
    {
        Console.WriteLine($"{number} -> да");
    }
    else
    {
        Console.WriteLine($"{number} -> нет");
    }
}

int result = GetInformation("Enter a five-digit number: ");
Palindrome(result);
