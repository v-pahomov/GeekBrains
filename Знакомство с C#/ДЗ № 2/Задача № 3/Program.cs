// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
int a;
while (true)
{
Console.WriteLine("Введите целое число от 1 до 7");
if (int.TryParse(Console.ReadLine(), out a) && (0 < a ) && (a < 8))
    break;
Console.WriteLine("Ошибка ввода!");
}
if (a < 6) Console.WriteLine($"{a} -> нет");
else Console.WriteLine($"{a} -> да");