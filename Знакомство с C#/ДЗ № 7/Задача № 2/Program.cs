//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
 
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер строки нужного элемента: ");
int findRows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер столбца нужного элемента: ");
int findColumns = int.Parse(Console.ReadLine() ?? "");

double [,] array = GetArray(rows, columns);
PrintArray(array);
GetElement(array, findRows, findColumns);

void GetElement(double [,] inArray, int findRows,int findColumns)
{
    if (findRows <= inArray.GetLength(0) && findColumns <= inArray.GetLength(1))
    {
        Console.WriteLine($"Элемент [{findRows}, {findColumns}]: {inArray[findRows, findColumns]:f3}");
    }
    else Console.WriteLine("Такого элемента нет в массиве");
}

double [,] GetArray(int m, int n)
{
    double[,] result = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble() * 10;
        }
    }
    return result;
}

void PrintArray(double [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]:f3} ");
        }
        Console.WriteLine();
    }
}