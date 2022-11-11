int firstNumber = new Random().Next(1, 99);
int secondNumber = new Random().Next(1, 99);
Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine(firstNumber);
}

else
{
    Console.WriteLine("Второе число не является квадратом первого.");
}
