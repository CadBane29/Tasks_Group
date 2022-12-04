// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("]");
    }
}

// int SumDiagonalMatrix(int[,] matrix) // возможное решение
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1);j++)
//         {
//             if(i == j) sum += matrix[i, j];
//         }
//     }
//     return sum;
// }

int SumDiagonalMatrix(int[,] matrix)
{
    int sum = 0;
    int minIndex = matrix.GetLength(0);
    if(matrix.GetLength(0) > matrix.GetLength(1)) minIndex = matrix.GetLength(1);
    for (int i = 0; i < minIndex; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix2D = CreateMatrixRndInt(rows, columns, -10, 10);
PrintMatrix(matrix2D);
int sumDiagonalMatrix = SumDiagonalMatrix(matrix2D);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sumDiagonalMatrix}");