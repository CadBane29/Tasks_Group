// Напишите программу, которая на
// 1. вход принимает число и
// 2. выдает его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// 3 -> 9
// 7 -> 49

Console.WriteLine("Введите целое число: ");
string strNum = Console.ReadLine(); // "-7)
int number = Convert.ToInt32(strNum);
// int num = Convert.ToInt32(Console.ReadLine());

int square = number * number;
Console.WriteLine($"Квадрат числа  {number} = {square}");