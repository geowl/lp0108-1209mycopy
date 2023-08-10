// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int ShowSecondNumber(int num)
{
    int result = number/10;
    int result1 = result%10;
    return result1;
}
int res = ShowSecondNumber(number);
Console.WriteLine($"Второе число из трехзначного числа -> {res}");