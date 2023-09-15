// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))


int AccermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AccermanFunction(m - 1, 1);
    }
    else
    {
        return (AccermanFunction(m - 1, AccermanFunction(m, n - 1)));
    }
}


Console.WriteLine("Введите диапозон чисел.!!! ВАЖНО, ТЕХНИЧЕСКИ ВЫВОД ОГРАНИЧЕН, m ДО 3, n ДО 10 !!! ");
Console.Write("Введите число m: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > 3 || numberTwo > 10)
{
    Console.WriteLine("Ошибка!");
}

int result = AccermanFunction(numberOne, numberTwo);
Console.WriteLine($"m = {numberOne}; n = {numberTwo}. -> A(m,n) = {result}");