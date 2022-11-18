// int n = 12345;
// double result = Math.Sqrt(n); // извлечение квадратного корня из числа

// double n1 = 5.099985645;
// double nRound = Math.Round(n1, 2, MidpointRounding.ToZero); // округление числа в данном примере до двух знаков
//                                   // стратегия оркугления до нуля
// Console.WriteLine(nRound);

// Задача 20: Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Enter the coordinates of the first point: "); //введите координты первой точки
double pointA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinates of the second point: "); //введите координты второй точки
double pointB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinates of the third point: "); //введите координты третьей точки
double pointC = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinates of the fourth point: "); //введите координты четвертой точки
double pointD = Convert.ToDouble(Console.ReadLine());


double Distance (double dotA, double dotB, double dotC, double dotD)
{
    double distanceAC = (dotA - dotC) * (dotA - dotC);
    double distanceBD = (dotB - dotD) * (dotB - dotD);
    double legSquare = Math.Sqrt(distanceAC + distanceBD);
    return legSquare;
}
double distance = Distance(pointA, pointB, pointC, pointD);
double result = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Distence between point int 2D space --> {result}");

// Теорема Пифагора, квадрат гипотенузы равен сумме квадратов катетов