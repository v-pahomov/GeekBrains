// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

float k1 = GetNumberFromUser("Введите k1", "Ошибка ввода!");
float b1 = GetNumberFromUser("Введите b1", "Ошибка ввода!");
float k2 = GetNumberFromUser("Введите k2", "Ошибка ввода!");
float b2 = GetNumberFromUser("Введите b2", "Ошибка ввода!");

CrossPoint(k1, b1, k2, b2);

void CrossPoint(float a1, float c1, float a2, float c2)
{
    float x = (c2 - c1) / (a1 - a2);
    float y = a1 * x + c1;
    Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x}, {y})");
}

float GetNumberFromUser(string message, string errorMessage)
{
    float c;
    while (true)
    {
    Console.WriteLine(message);
    if (float.TryParse(Console.ReadLine(), out c))
        return c;
    Console.WriteLine(errorMessage);
    }
}