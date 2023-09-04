﻿// 17. Напишите программу которая по заданному номеру
// четверти показывает диапозон возможных координат
// точек в этой четверти (x и y).
// //  2 четверть слева от 0, 1 четверть справа по X сверху
//  3 слева внизу 4 справа внизу

string CoordinateRange(int num)
{
    if (num == 1) return "x > 0 && y > 0";
    if (num == 2) return "x < 0 && y > 0";
    if (num == 3) return "x < 0 && y < 0";
    if (num == 4) return "x > 0 && y < 0";
    return null;
}

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = CoordinateRange(number);
Console.WriteLine(result != null ? result : "Некорректный ввод");