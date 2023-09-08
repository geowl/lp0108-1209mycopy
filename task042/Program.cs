// 42. Напишите программу, которая будет преобразовывать
// десятичное число в двоичное
// 46 - 101110
// 13 - 1101
// 2 -10

int DecimalToBinary (int number)
{
    int mult = 1;
    int binary = 0;
    while (number != 0)
    {
        binary += mult * (number%2);
        number = number/2;
        mult *=10;
    }
    return binary;
    
}

Console.WriteLine("Введите десятичное число");
int num = Convert.ToInt32(Console.ReadLine());

int binar = DecimalToBinary(num);
Console.WriteLine(binar);
