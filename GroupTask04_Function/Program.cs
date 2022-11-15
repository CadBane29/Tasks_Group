// 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Random number from segment 10 - 99 --> {number}");

int MaxDigit(int num) // int num = number
{
    int firstDigit = num / 10; // 78 --> 7
    int secondDigit = num % 10; // 78 --> 8
    if (firstDigit > secondDigit) return firstDigit; // Оператор return возвращает firstDigit
    return secondDigit;                              //  и прекращает работу метода
   
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Larget digit of a number --> {maxDigit}");