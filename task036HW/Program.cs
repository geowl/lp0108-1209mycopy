// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);

    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {

        if (i < arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" ]");
}

int SumElemOdd(int[] arr)
{
    int i = 0;
    int sum = 0;
    // for (int i = 0; i < arr.Length; i+=1)
    while (i < arr.Length)
    {
        if (arr[i] % 2 == 1)
        {
            sum += arr[i];
            i = i + 2;
        }

    }
    return sum;
}

int[] array = CreateArrayRndInt(4, 1, 9);
PrintArray(array);
SumElemOdd(array);
int result = SumElemOdd(array);
Console.WriteLine($"Сумма элементов стоящих в нечетных позициях = {result}");