// Задача 39: Напишите программу, которая 
// 1. перевернёт одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// Array.Reverse(array); - метод void, который переворачивает массив


int[] CreateArrayInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void ReverseArray(int[] arr2)
{
    for(int i = 0; i < arr2.Length / 2; i++) // при развороте массива обязательно делим пополам, чтобы заменить первую часть со второй
    {
        int temp = arr2[i]; // присваеваем переменной temp первое значение в массиве
        arr2[i] = arr2[arr2.Length - 1 - i]; // первое число массива заменяем на последнее
        arr2[arr2.Length - 1 - i] = temp; // присваиваем последнему элементу первый
    }
}

int[] array = CreateArrayInt(5, 1, 9);
PrintArray(array);
Console.WriteLine();
ReverseArray(array);
PrintArray(array);
Console.WriteLine();
Array.Reverse(array);
PrintArray(array);