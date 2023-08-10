// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня неделя");
int numDay = Convert.ToInt32(Console.ReadLine());

if (numDay <= 7) 
{
    if (numDay > 5)
    {
        Console.WriteLine("Выходной");
    }
    else 
    {
        Console.WriteLine("Рабочий день");
    }
}

