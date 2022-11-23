// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int n = -1;

while (n < 1)
{
    Console.Write("User, enter number: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("User, enter another number!");
}

int Multiplication(int num)
{
    for (int i = 1; i < n; i++)
    {
        num = i * num;
    }
    return num;
}

int multiplication = Multiplication(n);
Console.WriteLine($"{n} -> {multiplication}");