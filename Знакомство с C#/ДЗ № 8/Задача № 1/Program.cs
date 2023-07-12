// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
 
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine("Отсортированный массив");
SortArray(array);
PrintArray(array);


int [,] GetArray(int m, int n)
{
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(1,10);
        }
    }
    return result;
}

void SortArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int count = 0; count < array.GetLength(1); count++)
        {
            for (int j = 0; j < array.GetLength(1) - 1 - count; j++)
            {
                if (array[i,j] < array[i,j + 1])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,j + 1];
                    array[i,j + 1] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}