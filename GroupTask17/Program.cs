// 17. Напишите программу, которая принимает 
// 1. на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3.выдаётномер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Enter point coordinates "); //введите точки координат
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}
int quarter = Quarter(x, y);
string result = quarter > 0 ? 
    $"The specified coordinates correspond to a quarter -> {quarter}" //указанные координаты соответствуют четверти
    : "Incorrect coordinates entered!"; // введены не корректные координаты
Console.WriteLine(result);