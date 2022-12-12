// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите натуральное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целую степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
// int numberPower = RaiseNumberToPower(numberA, degree);
// Console.Write($"\nA = {numberA}; B = {degree} -> {numberPower}");

// int RaiseNumberToPower(int number, int degree)
// {
//     // return degree != 1 ? number * RaiseNumberToPower(number, degree - 1) : number;
//     return degree == 0 ? 1 : number * RaiseNumberToPower(number, degree - 1);
// }

Console.WriteLine(PowerRecMath(numberA, degree));

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}