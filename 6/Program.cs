// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

double i;
double sum = 0;
for (int n = 0; n < 4; n++)
{
Console.WriteLine("Введите число: ");
double.TryParse(Console.ReadLine(), out i);
    if (i > 0); sum = sum + 1;
}

Console.Write($" Количество положительных элементов = {sum} "); 


/*if (sum > 0);
    { Console.Write($" Сумма положительных элементов = {sum} ");   }
else
    {  Console.Write($" Положительных элементов нет "); }*/
