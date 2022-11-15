// 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("User, enter your fist number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("User, enter your second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool Square(int num1, int num2)
{
    return (num1 == num2 * num2) || (num2 == num1 * num1);
}
bool result = Square(firstNumber, secondNumber);
Console.WriteLine(result ? "Yes, it's square of number." : "No, choose another number.");