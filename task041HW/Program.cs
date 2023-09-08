// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример 1 - 0, 7, 8, -2, -2 -> 2
// Пример 2 - 1, -7, 567, 89, 223-> 3

// int CountNull()
// {
//     int count = 0;
//     int nums;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = nums;
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < arr.Length; i++)
//     {

//         if (i < arr.Length - 1) Console.Write($"{arr[i]}");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write(" ]");
// }

Console.WriteLine("Введите количество чисел:");
int count = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[count];

for (int i = 0; i < count; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int positiveCount = CountPositive(numbers);
Console.WriteLine($"Количество положительных чисел: {positiveCount}");

int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}