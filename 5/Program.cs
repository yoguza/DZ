// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[8];
for (int i = 0; i < 8; i++)
    {
    array[i]= new Random().Next(10);
    Console.Write($"{array[i]} ");
    }
int S = array[1];
for (int i = 3; i < array.Length; i = i + 2)
    {
        S = S + array[i];
    }
    Console.Write($"Сумма нечетных элементов = {S} ");