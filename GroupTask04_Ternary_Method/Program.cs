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
                                  // тогда - ? мы записываем firstDigit
    int max = firstDigit > secondDigit ? firstDigit : secondDigit; // тернарный оператор 
    return max;// если выполняется условие >        // иначе - : мы записываем secondDigit

    // или две последние строчки меняем на одну
    //return firstDigit > secondDigit ? firstDigit : secondDigit; // возвращает значение, а не true/ false
   
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Larget digit of a number --> {maxDigit}");