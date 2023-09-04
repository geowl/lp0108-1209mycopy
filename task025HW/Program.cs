// // 25. Напишите цикл, который принимает на вход
// // два числа (A и B) и возводит число А в 
// // натуральную степень B
// 3, 5 -> 243(3 в 5)
// 2, 4 -> 16

int Exponentiation(int x, int y)
{
    int res = 1;
    for (int i = 0; i < y; i++)
    {
        res*= x;
    }
    return res;
}

Console.WriteLine("Введите два числа, число А возводится в степень числа B");
Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B, которое является степенью");
int numB = Convert.ToInt32(Console.ReadLine());

int res = Exponentiation(numA, numB);
Console.WriteLine("А в степени В =" +res);

