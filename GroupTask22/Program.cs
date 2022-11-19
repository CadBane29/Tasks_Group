// Задача 22: Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Write("Enter number (N): ");
// int square = Convert.ToInt32(Console.ReadLine());
// int index = 0;

// void SquareNum (int numberN)
// {
//     while (index < numberN)
//     {
//         index++;
//         Console.WriteLine($"{index} --> {index * index}");
//     }
// }
// SquareNum(square);


// int n = -1;
// while (n < 1)
// {
//     Console.WriteLine("Enter number: ");
//     n = Convert.ToInt32(Console.ReadLine());
//     if (n < 1) Console.WriteLine("Data entered uncorrectly!");
// }

// string SqrTable(int n1)
// {
//     int count = 1;
//     string table = "";
//     while (count <= n1)
//     {
//         table = table + $"{count}|{count * count} \n"; // \n направляющий символ, перевод курсора на другую строку
//         count++;
//     }
//     return table;
// }
// string sqrTable = SqrTable(n);
// Console.WriteLine(sqrTable);

int n = -1;
while (n < 1)
{
    Console.WriteLine("Enter number: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Data entered uncorrectly!");
}

void Quarter(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} -> {count * count}");
        count++;
    }
}
Quarter(n);