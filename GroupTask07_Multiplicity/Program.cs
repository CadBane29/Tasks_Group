// 14. Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("User, please enter number.");
int number = Convert.ToInt32(Console.ReadLine());
int seven = 7;
int twentyThree = 23;

bool Multiplicity(int num1, int num2, int  num3)
{
    return (num1 % num2 == 0) && (num1 % num3 == 0);
}
bool result = Multiplicity(number, seven, twentyThree);
Console.Write(result ? "Yes, Multiple." : "No, not multiple times.");
