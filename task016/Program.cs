// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 - > Да
// -4, 16 - > Да
// 25, 5 - > Да
// 8, 9 - >  Нет

bool CheckSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
Console.WriteLine("Введите два числа");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());


bool result = CheckSquare(firstNumber, secondNumber);
Console.WriteLine(result ? "Да" : "Нет");