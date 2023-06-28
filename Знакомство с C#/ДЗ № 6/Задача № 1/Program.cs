// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

int m = GetNumberFromUser("Введите число М", "Ошибка ввода!");
float[] array = GetArrayFromUser(m, "Ошибка ввода!");
int positiv = GetCountPositiv(array);
Console.WriteLine($"[{String.Join("; ", array)}] -> {positiv}");

int GetCountPositiv(float[] arr)
{
    int p = 0;
    int count = 0;
    while (count < arr.Length)
    {
        if (arr[count] > 0)
        {
            p++;
        }
        count++;
    }
    return p;
}

float[] GetArrayFromUser (int size, string errorMessage1)
{
    int count1 = 0;
    float[] arr1 = new float [size];
    while (count1 < arr1.Length)
    {
        Console.WriteLine ($"Введите число № {count1 + 1}");
        if (float.TryParse(Console.ReadLine(), out arr1[count1]))
        {
            count1++;
        }
        else Console.WriteLine(errorMessage1);
    }
    return arr1;
}

int GetNumberFromUser(string message, string errorMessage)
{
    int c;
    while (true)
    {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out c) && c > 0)
        return c;
    Console.WriteLine(errorMessage);
    }
}