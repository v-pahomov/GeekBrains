// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число");
string userinput1 = Console.ReadLine() ?? "";
int N = int.Parse(userinput1);
int i = 1;

Console.Write($"{N} -> ");
while (i <= N)
    {
        if (i % 2 == 0) Console.Write($"{i}, ");
        i++;
    }
Console.WriteLine();