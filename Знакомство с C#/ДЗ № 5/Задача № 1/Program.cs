// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] array = GetArrayRandom(10, 100, 999);
int even = FindEvenNumber(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {even}");



int[] GetArrayRandom(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

int FindEvenNumber(int[] arr1)
{
    int countEven = 0;
    foreach (int el in arr1)
    {
        countEven += el % 2 == 0 ? 1 : 0;
    }
    return countEven;
}