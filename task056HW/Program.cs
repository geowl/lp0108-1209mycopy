// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindRowWithSmallestSumElements(int[,] matrix)
{
    int minSum = 0;
    int minRowIndex = -1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }

        if (i == 0 || rowSum < minSum)
        {
            minSum = rowSum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}


int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
Console.WriteLine();
PrintMatrix(array2d);

int minRowIndex = FindRowWithSmallestSumElements(array2d) + 1;
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex}");


