// 40. Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существать треугольник
// со сторонами такой длины.


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int [size];
//     Random rnd = new Random();
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
        
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
    
//         if(i < arr.Length -1) Console.Write($"{arr[i] }");   
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");

// }

bool ExistenceOfTrigle(int firstSide, int secondSide, int thirdSide)
{
    if (firstSide + secondSide > thirdSide && 
        firstSide + thirdSide > secondSide &&
        secondSide + thirdSide > firstSide ) return true;
        else return false;
}

Console.WriteLine("Введите первую сторону");
int side1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую сторону");
int side2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью сторону");
int side3 = Convert.ToInt32(Console.ReadLine());

bool result = ExistenceOfTrigle(side1, side2, side3);
Console.WriteLine(result ? "true" : "false");