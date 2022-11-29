// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

Console.Write("Пользователь, введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Пользователь, введите минимальное значение для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Пользователь, введите максимальное значение для массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayInt(size, min, max);
PrintArray(array);

int[] NewArray(int[] arr)
{
    int newArraySize = arr.Length / 2;  // создаем новый массив и делим его пополам
    if (arr.Length % 2 == 1) newArraySize += 1; // проверяем количество элементов в массиве и если оно нечетное запоминаем средний элемент
    int[] newArray = new int[newArraySize]; // создаем новый массив, который мы уменьшили в два раза
    for (int i = 0; i < arr.Length / 2; i++) // создаем цикл для уменьшеного вдвое массива
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];// перемножаем первый элемент с последним элементом старого массива
    }
    if (arr.Length % 2 == 1) newArray[newArraySize - 1] = arr[arr.Length / 2];// если массив нечетный приравниваем -
    return newArray;// - наш созданный массив без последнего значения к массиву деленному на два и оставляем последнее значение без имзменения
}

int[] newArr = NewArray(array);
PrintArray(newArr);
