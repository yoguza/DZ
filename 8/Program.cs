// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)     //генерация и вывод массива
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");

    }
Console.WriteLine();

}

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        for (int k = 0; k < array.GetLength(1) - 1; k++)
{
    if (array[i, k] < array[i, k + 1])
        {
            int temp = array[i, k + 1];
            array[i, k + 1] = array[i, k];
            array[i, k] = temp;
        }

    
    //(array [0, 1], array[array.GetLength(0)-1, i]) = (array[array.GetLength(0)-1, i], array [0, 1]);

}

Console.WriteLine("\n");

for (int i = 0; i < array.GetLength(0); i++)     // вывод массива
{
    for (int j = 0; j < array.GetLength(1); j++)
    {Console.Write($"{array[i, j]} ");}
Console.WriteLine();
}



