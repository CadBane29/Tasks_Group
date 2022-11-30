// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string DecimalNumber(int num)
// {
//     string count = string.Empty;
//     while (num > 0)
//     {
//         count = num % 2 + count;
//         num /= 2;
//     }
//     return count;
// }

// Console.Write("Введите число для перевода в двоичную систему: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(DecimalNumber(number));

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

int[] DecimalNumber(int num)
{
    int digits = 0;
    int number = num;
    while (number > 0) // цикл узнает сколько значений будет в массиве
    {
        number /= 2;
        digits += 1;
    }
    int[] array = new int[digits]; // создаем массив из стольких элементов, сколько раз прокрутился наш цикл
    for (int i = 0; i < array.Length; i++)
    {
        array[array.Length - i - 1] = num % 2; // к каждому индексу массива, мы присваиваем число которое получится при делении с остатком
        num /= 2;
    }
    return array;
}

Console.Write("Введите число для перевода в двоичную систему: ");
int numb = Convert.ToInt32(Console.ReadLine());
int[] decimalNumber = DecimalNumber(numb);
PrintArray(decimalNumber);
