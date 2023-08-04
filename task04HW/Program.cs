// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое целое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число");
int thrNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (firstNumber > max) max = firstNumber;
if (secondNumber > max) max = secondNumber;
if  (thrNumber > max) max = thrNumber;
Console.WriteLine ($"Максимальное число из 3 введеных = {max}");