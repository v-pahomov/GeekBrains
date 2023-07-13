// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()??"");

Console.WriteLine($"N = {number} -> {Recurs(number)}");


string Recurs(int number)
{
    if (number == 1) return "1";
    return number.ToString() + ", " + Recurs(number - 1); 
}