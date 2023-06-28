// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

int m = GetNumberFromUser("Введите число М", "Ошибка ввода!");
float[] array = GetArrayFromUser(m);
int positiv = GetCountPositiv(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {positiv}");



int GetCountPositiv(float[] arr)
{
    int count = 0;
    while (count < arr.Length)
    {
        if (arr[count] > 0)
        {
            count++;
        }
    }
    return count;
}

float[] GetArrayFromUser (int size)
{
    int count1 = 0;
    float[] arr1 = new float [size];
    while (count1 < arr1.Length)
    {
        Console.WriteLine ($"Введите число № {count1 + 1}");
        arr1[count1] = float.Parse(Console.ReadLine() ?? "");
        count1++;
    }
    return arr1;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out m))
        return m;
    Console.WriteLine(errorMessage);
    }
}