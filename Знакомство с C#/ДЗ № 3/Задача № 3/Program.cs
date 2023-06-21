// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
int N;
double count = 0;
double result;
while (true)
{
Console.WriteLine("Введите целое число");
if (int.TryParse(Console.ReadLine(), out N))
    break;
Console.WriteLine("Ошибка ввода!");
}
Console.Write($"{N} -> ");
while (count < N)
{
    if (count < N - 1)
    {
        count++;
        result = Math.Pow(count, 3);
        Console.Write($"{result}, ");
    }
    else
    {
        count++;
        result = Math.Pow(count, 3);
        Console.WriteLine($"{result}");
    }
}