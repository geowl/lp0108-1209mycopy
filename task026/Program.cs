// // 26. Напишите программу, которая принимает на 
// // вход число и выдает количество цифр в числе.

int DigitCount(int num)
{
    int count = 0;
    if (num == 0) return 1;

    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе = {number} состоит из {DigitCount(number)} чисел");