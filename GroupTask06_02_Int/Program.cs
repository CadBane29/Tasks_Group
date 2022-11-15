// 12. Напишите программу, которая 
// 1. будет принимать на вход два числа и 
// 2. выводить, является ли первое числократным второму. 
// 3. Если число 1 не кратно числу 2, то
// 4. программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("User, insert first number.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("User, insert second number.");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Multiplicity (int number1, int number2)
{
    return number1 % number2;
}
int result = Multiplicity(firstNumber, secondNumber);
Console.WriteLine(result == 0 ? "Insert numbers - multiplicity" : $"First number {firstNumber}, have remainder of {secondNumber} --> {result}.");