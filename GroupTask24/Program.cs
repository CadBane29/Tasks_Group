// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чиселот 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

int a = -1;
// int sum = 0; -- Таким образом мы обЪявляем глобальную переменную, так делать НЕЛЬЗЯ!!!

while (a < 1)
{
    Console.WriteLine("Enter number from 1 to A: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a < 1) Console.WriteLine("Enter another number!");
}

int SumDigits(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++) // если переменную sum запихнуть в тело цикла, она будет каждый раз обнуляться
    {
        sum = sum + i;
    }
    return sum;
}

if (a > 0)
{
    int sumDigits = SumDigits(a);
    Console.WriteLine($"Sum numbers from 1 to {a} -> {sumDigits}");
}
else Console.WriteLine("Enter another number!");