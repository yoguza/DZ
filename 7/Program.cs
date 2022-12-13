// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int x, y;
Console.WriteLine($"Введите число строк массива: ");
int.TryParse(Console.ReadLine()!, out x);
Console.WriteLine($"Введите число столбцов массива: ");
int.TryParse(Console.ReadLine()!, out y);

int [,] array = new int[x, y];

for(int i = 0; i<x; i++)
{
    for(int j = 0; j<y; j++)
    {
        array [x, y] = new Random().Next(-9, 10);
        Console.Write($"{array [x, y]} ");
    }

Console.WriteLine();
}
