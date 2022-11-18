// Задача 18: Напишите программу, которая по
// 1. заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Enter quarter number: "); // введите номер четверти
string quarter = Console.ReadLine()!;

string RankRange(string quarter1)
{
    if (quarter1 == "1") return "x > 0 && y > 0";
    if (quarter1 == "2") return "x < 0 && y > 0";
    if (quarter1 == "3") return "x < 0 && y < 0";
    if (quarter1 == "4") return "x > 0 && y < 0";
    return "Incorrect data entered!"; // введены неверные данные
}
string rankRange = RankRange(quarter);
Console.WriteLine(rankRange);
