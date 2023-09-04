// // 33
// определяет присутствует ли заданное число
// в массиве.
// 4; массив [6,7,19,345,3] -> Нет
// 3; [6,7,19,345,3] - > Да

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

bool AvalilabilityNumber(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            return true;
        }
    }
    return false;
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = AvalilabilityNumber(array, number);
Console.WriteLine(result ? "Да" : "Нет");