// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int SumNumbersToN(int m, int n)
{
    if (m == n) return m;
    else if (m < n) return SumNumbersToN(m, n - 1) + n;
    else return SumNumbersToN(m, n + 1) + n;
}

Console.WriteLine(SumNumbersToN(m, n));