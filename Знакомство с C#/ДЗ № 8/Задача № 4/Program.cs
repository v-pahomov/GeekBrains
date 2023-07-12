//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = GetNumberFromUser("Введите X: ");
int y = GetNumberFromUser("Введите Y: ");
int z = GetNumberFromUser("Введите Z: ");
Console.WriteLine();

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
PrintArray(array3D);

int GetNumberFromUser(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine()??"");
  return output;
}

void PrintArray (int[,,] array3D)
{
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        Console.Write( $"X({x}) Y({y}) Z({z}) = {array3D[x,y,z]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  for (int i = 0; i < temp.Length; i++)
  {
    temp[i] = new Random().Next(10, 100);
    for (int j = 0; j < i; j++)
    {
      while (temp[i] == temp[j])
      {
        temp[i] = new Random().Next(10, 100);
        j = 0;
      }
    }
  }
  int count = 0;
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
