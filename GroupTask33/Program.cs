// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayInt(int size, int min, int max)
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

int[] array = CreateArrayInt(5, 0, 999);
PrintArray(array);

bool FindNumberArray(int[] array, int numb)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(numb == array[i]) return true;
    }
    return false;
}

Console.Write("Введите число, искомое в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выбранное число присутствует в массиве?");
Console.WriteLine(FindNumberArray(array, number) ? "Да!" : "Нет!");