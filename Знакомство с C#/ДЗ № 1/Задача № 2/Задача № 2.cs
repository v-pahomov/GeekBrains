// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите первое число");
string userinput1 = Console.ReadLine() ?? "";
int a = int.Parse(userinput1);

Console.WriteLine("Введите второе число");
string userinput2 = Console.ReadLine() ?? "";
int b = int.Parse(userinput2);

Console.WriteLine("Введите третье число");
string userinput3 = Console.ReadLine() ?? "";
int c = int.Parse(userinput3);

int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"-> max = {max}");