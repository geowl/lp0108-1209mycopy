// 29. задает массив из 8 элементов, заполненный 
// псевдослучайными числами и выводит их на экран
// 1,2,5,7,19 - > {1,2,3,5,7,19}



void FillArr(int[] mass)
{
    int i = 0;
    while (i < mass.Length)
    {
        mass[i] = new Random().Next(1, 100);
        i++;
    }
}
void PrintArr(int[] mass)
{
    int i = 0;
    while (i < mass.Length)
    {
        Console.Write($"{mass[i]} ");
        i++;
    }
}

int[] array = new int[8];
FillArr(array);
PrintArr(array);