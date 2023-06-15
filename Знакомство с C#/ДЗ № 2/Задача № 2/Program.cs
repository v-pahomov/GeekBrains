// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
int a;
while (true)
{
Console.WriteLine("Введите целое число");
if (int.TryParse(Console.ReadLine(), out a))
    break;
Console.WriteLine("Ошибка ввода!");
}
int b = a;

while (a >=1000) a = a/10;
if (a >= 100) Console.WriteLine($"{b} -> {a % 10}");
else Console.WriteLine($"{b} -> Третьей цифры нет");
