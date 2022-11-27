// Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9].
// 3. Вывести массив в консоль.
// 4. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateRndArrayInt(int size, int min, int max) // метод вызова массива
{
    int[] arr = new int[size]; // new означает, что мы выделяем память в компьютере
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1); // +1 чтобы пользователь смог ввести от -9 до 9, а не 8
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int GetSumNegativeElem(int[] arr)
{
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative += arr[i];
    }
    return sumNegative;
}

int GetSumPositiveElem(int[] arr)
{
    int sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPositive += arr[i];
    }
    return sumPositive;
}

int[] array = CreateRndArrayInt(12, -9, 9); // создаем ссответствующий массив по данным размерам
PrintArray(array);
int sumNegativeElem = GetSumNegativeElem(array);
int sumPositiveElem = GetSumPositiveElem(array);
Console.WriteLine($"Сумма положительных чисел в массиве = {sumPositiveElem}.");
Console.WriteLine($"Сумма отрицательных чисел в массиве = {sumNegativeElem}.");