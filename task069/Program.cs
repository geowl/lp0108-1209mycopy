// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Promt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ValidationNaturalNumber(int numberB)
{
    if (numberB < 1)
    {
        numberB = Promt("Неверно введено число. Введите натуральное число");
    }
    return numberB;
}

int Exponentiation(int num1, int num2) // 3, 5; 3, 4;3,3; 3,2;3,1;3,1
{
    if (num2 == 0) return 1; // 1
    return num1*Exponentiation(num1, num2 - 1); // это стек: 3, 5; 3, 4 ; 3,3; 3,2; 3,1;3
 // 3*3*3*3*3 * 1=
}

int numA = Promt("Введите первое число: ");

int numB = Promt("Введите второе число: ");
numB = ValidationNaturalNumber(numB);
Console.WriteLine(Exponentiation(numA, numB));
