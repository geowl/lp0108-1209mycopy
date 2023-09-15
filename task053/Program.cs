// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void ReaplceFirstAndLastLists(int[,] arr)
{
    int firstRow = 0;
    int lastRows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        int temp = arr[firstRow, j];
        arr[firstRow, j] = arr[lastRows, j];
        arr[lastRows, j] = temp;
    }
}


void PrintArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintArray(matrix);
ReaplceFirstAndLastLists(matrix);
Console.WriteLine();
PrintArray(matrix);