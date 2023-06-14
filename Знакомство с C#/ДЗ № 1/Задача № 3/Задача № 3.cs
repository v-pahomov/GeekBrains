// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите число");
string userinput1 = Console.ReadLine() ?? "";
int a = int.Parse(userinput1);

if (a % 2 == 0) Console.WriteLine($"{a} -> да");
else Console.WriteLine($"{a} -> нет");

