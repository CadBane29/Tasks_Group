// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] arr)
{
    int[] tempArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        tempArray[i] = arr[i];
    }
    return tempArray;
}

int[] givenArray = CreateArrayInt(7, 1, 10);
PrintArray(givenArray);
Console.WriteLine();
int[] copyArray = CopyArray(givenArray);
PrintArray(copyArray);