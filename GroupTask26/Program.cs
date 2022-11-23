// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int number = -1;

// while (number < 0)
// {
//     Console.WriteLine("User, enter number: ");
//     number = Convert.ToInt32(Console.ReadLine());
//     if (number < 0) Console.WriteLine("Enter positive number!");
// }

// int Digits(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// int result = Digits(number);
// Console.WriteLine($"Количество цифр в числе {number} ---> {result}");

Console.WriteLine("User, enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digits(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count == 0 ? 1 : count;
}

if (number < 0) number = -number; // Math.Abs(-123); записывает число в виде положительного
int result = Digits(number);
Console.WriteLine($"Количество цифр в числе {number} ---> {result}");