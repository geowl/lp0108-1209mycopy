// Напишите программу которая принимает на вход число
// и выдает сумму цифр в числе
// 452 - 11
// 82 - 10
// 9012 - 12

int Sum(int num)
{
    int total = 0;
    while (num != 0)
    {
        total += num%10;
        num /=10;
    }
    return total;
}



Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum (number);
Console.WriteLine("Итог =" + sum);
