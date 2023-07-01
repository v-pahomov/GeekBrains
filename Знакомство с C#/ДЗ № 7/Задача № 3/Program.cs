//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
 
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int [,] array = GetArray(rows, columns);
PrintArray(array);
GetAverengeByColumns(array);


void GetAverengeByColumns(int [,] inArray)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0;  j < inArray.GetLength(1); j++)
    {
        double summ = 0;
        int i = 0;
        while (i < inArray.GetLength(0))
        {
            summ = summ + inArray[i,j];
            i++;
        }
        double average = summ / inArray.GetLength(0);
        if (j < inArray.GetLength(1) - 1) Console.Write($"{average}; ");
        else Console.WriteLine($"{average}.");
    }
}

int [,] GetArray(int m, int n)
{
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(100);
        }
    }
    return result;
}

void PrintArray(int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}