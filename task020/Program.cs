// 20. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними
// в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1;-1)-> 7,21

double Find(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

Console.WriteLine("Введите координаты точки А");
Console.Write("X1: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X2: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());

double result = Find (xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
Console.WriteLine($"{Math.Round(result, 2, MidpointRounding.ToZero)}");


// double sqrt = Math.Sqrt(5);
// double pow = Math.Pow(5,3);
// double d = 5.09315645412; //5,09
// double dround = Math.Round(d, 2);
// Console.WriteLine(dround);
// Console.WriteLine($"{d:F3}");