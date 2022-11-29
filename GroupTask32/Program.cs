// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateRndArrayInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

void NegativeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

Console.Write("Пользователь, введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Пользователь, введите минимальное значение для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Пользователь, введите максимальное значение для массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRndArrayInt(size, min, max);
PrintArray(array);
NegativeArray(array);
PrintArray(array);
