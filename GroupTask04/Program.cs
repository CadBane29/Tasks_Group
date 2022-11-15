// 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Random number from segment 10 - 99 --> {number}");

int firstDigit = number / 10; // 78 --> 7
int secondDigit = number % 10; // 78 --> 8

// При одной строчки условия, можно писать в одну строку
if (firstDigit > secondDigit)  Console.WriteLine($"Larget digit of a number --> {firstDigit}");
else Console.WriteLine($"Larget digit of a number --> {secondDigit}");

//Console.WriteLine(Math.Max(firstDigit, secondDigit));
