// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите первое натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(firstNumber, secondNumber);


void NaturalNumbers(int num1, int num2)
{
    if(num1 <= num2)
    {
        Console.Write($"{num1} ");
        if(num1 == num2) return;
        NaturalNumbers(num1 + 1, num2);              
    }
    else if(num1 >= num2)
    {
        Console.Write($"{num1} ");
        if(num1 == num2) return;
        NaturalNumbers(num1 - 1, num2);   
    }

}
