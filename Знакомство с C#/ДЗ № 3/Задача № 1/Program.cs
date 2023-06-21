// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
int a;
while (true)
{
Console.WriteLine("Введите пятизначное число");
if (int.TryParse(Console.ReadLine(), out a) && (9999 < a ) && (a < 100000))
    break;
Console.WriteLine("Ошибка ввода!");
}

if (a%10==a/10000 && (a%100)/10==(a/1000)%10) Console.WriteLine($"{a} -> да");
else Console.WriteLine($"{a} -> нет");

