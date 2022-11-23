// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, 
// 2. заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]


// int[] arr = new int[8]; // обьявляем массив с указанным значением в массиве

// void RandomArray(int[] array) // создаем метод в котором будут добавляться рандомные значения в массив
// {   // метод Random rnd нужно создавать вне цикла, чтобы не было одинаковых значений
//     Random rnd = new Random(); // берется класс Random и объявляется переменная rnd, чтобы из нее брать значения в массив 
//     for (int i = 0; i < array.Length; i++)// создаем цикл, чтобы перебирать значения в массиве
//     {
//         array[i] = rnd.Next(0, 2); // в массив от индекса добавляем переменную Random от 0 до 2, потому что второе значение 
//                                    // будет -1, по факту 0 до 1 значения будут добавлены и заполняем массив 0 и 1
//     }
// }

// void PrintArray(int[] array) // второй метод мы берем для вывода в терминал, нашего массива
// {
//     for (int i = 0; i < array.Length; i++)// создаем цикл, для вывода в терминал
//     {
//         Console.Write($"{array[i]} "); // и выводим уже в терминал
//     }
// }

// RandomArray(arr);
// PrintArray(arr);

int InputNumber()
{
    int num = 0;
    while (num == 0)
    {
        Console.Write("Введите размер массива: ");
        num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        if (num == 0) Console.WriteLine("\nРазмер массива не может быть равен нулю!\n");
    }
    return num;
}

int[] FillArray(int size)
{
    int[] arr = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

string ArrayToString(int[] arr)
{
    string result = "[ ";
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        result += $"{arr[i]}, ";
    }
    result += $"{arr[arr.Length - 1]} ]";
    return result;
}

int arraySize = InputNumber();
int[] array = FillArray(arraySize);
string output = ArrayToString(array);

Console.WriteLine(output);