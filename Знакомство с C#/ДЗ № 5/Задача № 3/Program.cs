// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] array = GetDoubleArray(10);
double min = GetMinFromArray(array);
double max = GetMaxFromArray(array);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.WriteLine($"] -> {max} - {min} = {max - min}");


double GetMaxFromArray(double[] arr)
{
    int j = 0;
    double maximum = arr[0];
    while (j < arr.Length - 1)
    {
        if (arr[j] > maximum)
        {
            maximum = arr[j];
        }
        j++;
    }
    return maximum;
}

double GetMinFromArray(double[] arr)
{
    int i = 0;
    double minimum = arr[0];
    while (i < arr.Length - 1)
    {
        if (arr[i] < minimum)
        {
            minimum = arr[i];
        }
        i++;
    }
    return minimum;
}

double[] GetDoubleArray(int size)
{
    double[] arr = new double[size];
    for (int c = 0; c < size; c++)
    {
        arr[c] = new Random().NextDouble() * 100;
    }
    return arr;
}