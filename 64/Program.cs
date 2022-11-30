// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

void NumbersToN(int n, int m)
{   

    if (n > m)  
    {
        if (m < n)
        // NumbersToN(n-1, m);
        NumbersToN(n, m+1);
    }  
    if (m == n)
        Console.Write($"{m}");
    else
        Console.Write($", {m}");
}

NumbersToN(n, 1);
Console.WriteLine();