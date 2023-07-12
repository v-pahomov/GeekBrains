// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

Console.Write("Введите количество строк 1-го массива: ");
int rows1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов 1-го массива: ");
int columns1= int.Parse(Console.ReadLine() ?? "");
int rows2 = columns1;
Console.Write("Введите количество столбцов 2-го массива: ");
int columns2= int.Parse(Console.ReadLine() ?? "");

int[,] array1 = GetArray(rows1, columns1);
int[,] array2 = GetArray(rows2, columns2);
int[,] multiMatrix = MultiplicateMatrixe(array1, array2);
Console.WriteLine("Первая матрица: ");
PrintArray(array1);
Console.WriteLine("Вторая матрица: ");
PrintArray(array2);
Console.WriteLine("Результирующая матрица: ");
PrintArray(multiMatrix);


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

int[,] MultiplicateMatrixe(int[,] array1, int[,] array2)
{
    int[,] tempMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i,j] = 0;
            for (int c = 0; c <= tempMatrix.GetLength(0); c++)
            {
                tempMatrix[i, j] += array1[i, c] * array2[c, j];
            }
        }
    }
    return tempMatrix;
}