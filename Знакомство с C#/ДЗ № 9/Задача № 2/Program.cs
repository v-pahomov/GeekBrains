// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()??"");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()??"");

int sum = SumBetweenTwoNumber(m, n);

Console.WriteLine($"M = {m}, N = {n} -> {sum}");

int SumBetweenTwoNumber(int a, int b)
{
    int sum = 0;
    if (b < a) return 0;
    if (b >= a) return sum + b + SumBetweenTwoNumber(a, b - 1); 
    return 0;
}