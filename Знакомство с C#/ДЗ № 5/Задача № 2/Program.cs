// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] array = GetArrayRandom(11, 0, 100);
int sumOdd = GetSumOdd(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {sumOdd}");



int[] GetArrayRandom(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

int GetSumOdd(int[] arr)
{
    int sum = 0;
    int count = 0;
    foreach (int elem in arr)
    {
        sum += count % 2 == 0 ? 0 : arr[count];
        count++;
    }
    return sum;
}