// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers(int from, int to)
{
    int num = 0;
    int sum = 0;
    if (from > 0 && to > 0)
    {
        for (int i = from; i <= to; i++)
        {
            num = i;
            sum += num;
        }
    }
    return sum;

}

Console.WriteLine("Введите диапозон натуральных чисел");
Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int result = SumNaturalNumbers(numberOne, numberTwo);
Console.WriteLine($"М = {numberOne}; N = {numberTwo}. -> {result}");
