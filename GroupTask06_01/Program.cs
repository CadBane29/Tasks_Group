// 12. Напишите программу, которая 
// 1. будет принимать на вход два числа и 
// 2. выводить, является ли первое числократным второму. 
// 3. Если число 1 не кратно числу 2, то
// 4. программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Write("User, enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("User, enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool Multiplicity (int number1, int number2)
{
    if (number1 % number2 == 0) return true;
    return false;
}
bool result = Multiplicity(firstNumber, secondNumber);
Console.Write(result ? "Multiplicity" : $"Not Multiplicity, remainder -> {firstNumber % secondNumber} ");
