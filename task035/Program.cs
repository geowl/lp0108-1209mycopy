// 35. массив из 123 случайных чисел.
// найдите кол-во элементов массива, значения которых
// лежат на отрезке [10,99].

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

int RangeDigitalElementCount(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max) count++;
        
    }
    return count;
}

Console.WriteLine("Введите максимальное и минимальное число для диапозона поиска ");
int minimum = Convert.ToInt32(Console.ReadLine()); 
int maximum = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArrayRndInt(123, 10, 99);
PrintArray(array);
int result = RangeDigitalElementCount(array, minimum, maximum);
Console.WriteLine($"в заданном диапозоне находится {result} чисел(-о, -а)");