// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
        Console.Write("\n[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,4}", matrix[i, j]);
            Console.Write(j < matrix.GetLength(1) - 1 ? ","
                          : string.Empty);
        }
        Console.Write(" ]\n");
    }

}

int[] MatrixToArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    return array;
}

void PrintArray(int[]arr)
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,2}", arr[i]);
        Console.Write(i < arr.Length - 1 ? ","
        : string.Empty);
    }
    Console.Write("]\n");
}

int SizeRequencyElemntsArray(int[] array)
{
    int size = 0;
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] != temp)
        {
            size++;
            temp = array[i];
        }
    }
    return size;
}

int[,] RequencyElementsArray(int[] array)
{
    int size = SizeRequencyElemntsArray(array);
    int temp = 0;
    int[,] matrix = new int[size, 2];
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] != temp)
        {
            index++;
            temp = array[i];
            matrix[index, 0] = array[i];
        }
        if(array[i] == temp) matrix[index, 1]++;
    }
    return matrix;
}

void PrintMatrixSpecial(int[,] matrix, string beginRow, string firstRow, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j == 0) Console.Write($"{matrix[i,j],2}{firstRow}");
            else Console.Write($"{matrix[i,j],2}");
        }
        Console.WriteLine(endRow);
    }
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix);
int[] array = MatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
int[,] requencyMatrix = RequencyElementsArray(array); 
PrintMatrixSpecial(requencyMatrix, "Число" , " повторяется", " раз.");


// int[] MatrixToArray(int[,] matrix)
// {
//     int[] arr = new int[matrix.Length];
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             arr[k++] = matrix[i, j];
//         }
//     }
//     return arr;
// }


// void PrintArray(int[] arr)
// {
//     Console.Write("\n[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write("{0,4}", arr[i]);
//         Console.Write((i < arr.Length - 1) ? ","
//         : string.Empty);
//     }
//     Console.WriteLine(" ]\n");
// }

// void CountValue(int[] arr)
// {
//     int count = 1;
//     int num = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] == num) count++;
//         else
//         {
//             PrintMessage(num, count);
//             num = arr[i];
//             count = 1;
//         }
//     }
//     PrintMessage(num, count);
// }

// void PrintMessage(int num, int count)
// {
//     Console.WriteLine($"Число {num}, выводится {count} раз.");
// }

// int[,] matrix = CreateMatrixRndInt(3, 4, 1, 9);
// PrintMatrix(matrix);
// int[] array = MatrixToArray(matrix);
// Array.Sort(array);
// PrintArray(array);
// CountValue(array);