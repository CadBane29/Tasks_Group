// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max - 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

// int[,] ReplaceRowsColumnsByMatrix(int[,] matrix)
// {
//     int[,]replaceMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             replaceMatrix[i, j] = matrix[j, i];            
//         }
//     }
//     return replaceMatrix;
// }

bool ComparisonMatrix(int[,]matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

void ReplaceRowsColumnsMatrix(int[,]matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows - 1; i++) // для оптимизации, читай ниже
    {
        for (int j = i + 1; j < columns; j++) // +1 для того, чтобы метод не менял значения 0 индекса строки
        {                                     // и последнего в стобце
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine(ComparisonMatrix(matrix) ? "Измененный массив: " 
                 : "Значения не корректны!");
ReplaceRowsColumnsMatrix(matrix);
PrintMatrix(matrix);
//int[,]changedMatrix = ReplaceRowsColumnsByMatrix(matrix);
//PrintMatrix(changedMatrix);