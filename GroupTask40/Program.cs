﻿// Задача 40: Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

bool Triangle(int a1, int b1, int c1)
{
    return a1 < b1 + c1 && b1 < c1 + a1 && c1 < a1 + b1;
}

Console.Write("Введите первую сторону треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите трутью сторону треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());

bool triangle = Triangle(a, b, c);
Console.WriteLine(triangle ? "Треугольник со сторонами такой длины может существовать!"
: "Треугольник со сторонами такой длины существовать не может!");