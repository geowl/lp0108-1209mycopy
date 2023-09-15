﻿// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] FindIndexMinimumElement(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int rowMin = 0;
    int colMin = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] < matrix[rowMin, colMin])
            {
                rowMin = i;
                colMin = j;
            }
        }
    }
    return new int[] { rowMin, colMin };
}

int[,] DeleteRowAndColOfMinElem(int[,] matrix, int rowMin, int colMin)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] newMatrix = new int[rows - 1, columns - 1];
    int m = 0, n = 0;

    for (int i = 0; i < rows - 1; i++)
    {
        if (m == rowMin) m += 1;
    }
        for (int j = 0; j < columns - 1; j++)
        {
            if (n == colMin) n += 1;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
}


void PrintMatrix(int[,] matrix)
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
PrintMatrix(matrix);
Console.WriteLine();
int[] minIndex = FindIndexMinimumElement(matrix);
int[,] newMatrix = DeleteRowAndColOfMinElem(matrix, minIndex[0], minIndex[1]);
PrintMatrix(matrix);
