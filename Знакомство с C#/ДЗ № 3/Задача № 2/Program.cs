// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
int X, Y, Z, X1, Y1, Z1;

try
{
    Console.WriteLine("Введите X");
    X = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите Y");
    Y = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите Z");
    Z = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите X1");
    X1 = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите Y1");
    Y1 = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите Z1");
    Z1 = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка вводаданных! {exc.Message}");
    return;
}
double D1 = Math.Sqrt((X1-X)*(X1-X)+(Z1-Z)*(Z1-Z));
double D2 = Math.Sqrt((D1*D1)+(Y1-Y)*(Y1-Y));
Console.WriteLine($"A ({X}, {Y}, {Z}); B ({X1}, {Y1}, {Z1}) -> {D2:f5}");