// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void CheckNumber(int numb)
// {   
//     numb = -1;
//     while(numb < 1)
//     {
//         //Console.Write("Введите число Фибоначчи: ");
//         numb = Convert.ToInt32(Console.ReadLine());
//         if(numb <= 0) Console.Write("Введите другое число:");
//     }
// }
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

int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    arr[1] = 1;
    for(int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

Console.WriteLine("Введите число Фибоначчи: ");
// int number = 0;
// CheckNumber(number);
int number = Convert.ToInt32(Console.ReadLine());
int[] array = Fibonacci(number);
PrintArray(array);
