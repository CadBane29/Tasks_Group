// 14. Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("User, please enter number.");
int number = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num1)
{
    return (num1 % 7 == 0) && (num1 % 23 == 0);
}
bool result = Multiplicity(number);
Console.Write(result ? "Multiplicity" : "Not Multiplicity");
