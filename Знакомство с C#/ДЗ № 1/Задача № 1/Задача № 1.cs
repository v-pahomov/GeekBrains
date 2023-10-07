// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число");
string userinput1 = Console.ReadLine() ?? "";
int a = int.Parse(userinput1);

Console.WriteLine("Введите второе число");
string userinput2 = Console.ReadLine() ?? "";
int b = int.Parse(userinput2);

if (a > b) Console.WriteLine($"-> max = {a}");
else Console.WriteLine($"-> max = {b}");

if (a > b) Console.WriteLine($"-> min = {b}");
else Console.WriteLine($"-> min = {a}");


// йцукенгш
