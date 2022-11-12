// Напишите программу, которая на 
// 1. вход принимает два числа и 
// 2. проверяет, является перове число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"Число {number1}, является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"Число {number1}, не ялвяется квадратом числа {number2}, введите другое число!");
}