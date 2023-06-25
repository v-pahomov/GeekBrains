// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
double A = GetNumberFromUser("Введите число А", "Ошибка ввода!");
double B = GetNumberFromUser("Введите число B", "Ошибка ввода!");

double C = DegreeNumber(A, B);

Console.WriteLine($"{A}, {B} -> {C:f3}");

//////////////////////////////

double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
    Console.WriteLine (message);
    if (double.TryParse(Console.ReadLine(), out double userNumber))
        return userNumber;
    
    Console.WriteLine (errorMessage);
    }
}

double DegreeNumber(double number1, double number2)
{
    double result = Math.Pow(number1, number2);
    return result;
}