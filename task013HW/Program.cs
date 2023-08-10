// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (number >= 100)
{
    result = (number / 100) % 10;
}
else
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

    Console.WriteLine($"Третья цифра числа = {result}");




