// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();
int n;
Console.Write($"Введите N: ");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine($"{PrintNums(n, 1)}");

String PrintNums (int L, int R)
{
    if (L <= R)
        return L.ToString();
        //Console.WriteLine();
    return $"{L} {PrintNums(L - 1, R)}";
}

