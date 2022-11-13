// Напишите программу, которая
// 1. на вход принимает одно число (N), а 
// 2. на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите целое число.");
int N = Convert.ToInt32(Console.ReadLine());
int Negative = N * -1;
//Console.WriteLine(Negative);
while (N != Negative)
{
    if (N > Negative)
    {
        N = N - 1;
        Console.WriteLine(N);
    }
    else
    {
        N = N + 1;
        Console.WriteLine(N);
    }
}
Console.WriteLine("Промежуток чисел от натурального к противоположному натуральному и наоборот.");