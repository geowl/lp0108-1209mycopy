// Напишите программу, которая принимает на вход число n
// и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120 

int MultiplicationNumber(int num)
{
    int mult = 1;
    //  for когда известно количество итераций, while когда нет.
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            mult *= i;
        }
    }
    return mult;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine("Введено некорректное число");
    return;
}
else 
{
    int multiplicationNumber =  MultiplicationNumber(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {multiplicationNumber}");
}