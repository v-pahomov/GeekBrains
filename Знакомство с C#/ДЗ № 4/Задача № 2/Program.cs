// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int a = GetNumberFromUser("Введите целое число a: ", "Ошибка ввода!");

int s = GetSumDigit(a);

Console.WriteLine($"{a} -> {s}");



int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
    Console.WriteLine (message);
    if (int.TryParse(Console.ReadLine(), out int userNumber))
        return userNumber;
    
    Console.WriteLine (errorMessage);
    }
}

int GetSumDigit(int number)
{
    int sum = 0;
    while (number / 10 > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    sum = sum + number;
    return sum;
}