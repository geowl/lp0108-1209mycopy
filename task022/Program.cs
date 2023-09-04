// 22. Напишите программу, которая принимает на вход число(N)
// и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1,4,9,16,25
// 2 -> 1,4

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= n)
// {
//     Console.WriteLine($"{i, 3} -> {i*i, 9}");
//     i++;
// } - без метода

void WriteTableSquare(int number)
{
    int i = 1;
    while (i <=number)
    {
        // if (i > 3) return; покажет только 3 шт.   
        Console.WriteLine($"{i, 3} -> {i*i, 5}");
        i++; 
    }
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

WriteTableSquare(n);