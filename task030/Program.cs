// // 30. МАССИВ
// // Напишите программу, которая
// // выводит массив из 8 элементов, заполненный
// // нулями и единицами в случайном порядке.
// // пример [1,0,1,1,0,1,0,0]

// int[] array = new int [8]; // 0 1 2 3 4 5 6 7
// int[] array1 = new int[8] {5, 7, 6, 8, 9, 10, 11};
// int[] array 2 = new int[8]; {5,7,8,9,10,11,12,13};
// int[] array3 = {5,7,8,9,10,11,12,13};
// var array4 = new int[8];
// var num = 54/13 - 54 * 3 - (5/2);


// array[6] = 6456;
// array[2] = 34; 

// for (int i = 1; i < array.Lenght; i++)
// {
//     array[i] = i * i; 
//     Console.Write(array[i] + " ");
// }

void FillArr(int[] mass)
{
    int i = 0;
    while (i < mass.Length)
    {
        mass[i] = new Random().Next(2);
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

