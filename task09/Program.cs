//  Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

int number = new Random().Next(10, 100); //99+1
Console.WriteLine($"Случайное число в диапозоне 10 - 99 -> {number}");
// int firstDigit = number / 10; // 78/10 = 7.8 -> 7
// int secondDigit = number % 10; // 78%10 =  70 + 8 

// // if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// // else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit; 
// Console.WriteLine($"Наибольшая цифра числа -> {result}");

int maxDigit = MaxDigit(number);   
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit1 = MaxDigit(56);   
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");

int maxDigit2 = MaxDigit(89);   
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");


int MaxDigit(int num) // num = number (значения!); num = 93, num = 56, num 89 ...
{
    int firstDigit = num / 10;
    int secondDigit = num / 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}