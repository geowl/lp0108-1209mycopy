// 17. Напишите программу которая принимает на вход 
// координаты точки (X и Y), причем Х не равен 0 и У не равен 0,
//  и вылаеи номер плоскости в которой находится эта точка
//  2 четверть слева от 0, 1 четверть справа по X сверху
//  3 слева внизу 4 справа внизу

int Quatter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quatter = Quatter(xCoordinate, yCoordinate);
string result = quatter > 0 
                        ? $"Указанные координаты соответствуют четверти -> {quatter}"
                        : "Введены некорректные данные";
Console.WriteLine(result);