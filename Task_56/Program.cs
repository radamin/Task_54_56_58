// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.



Console.Write("Enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixInt(row, column, 1, 15);
PrintMatrixInt(array);
Console.WriteLine();
Console.WriteLine($"The row with the smallest sum - {GetRowNumber(array)}");

int[,] CreateMatrixInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}

void PrintMatrixInt(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write('[');
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
      else Console.Write($"{matrix[i, j],4}, ");
    }
    Console.WriteLine("]");
  }
}

int GetRowNumber(int[,] array)
{
  int row = 0;
  int minsum = 0;
  for (int i = 0; i < array.GetLength(1); i++)
  {
    minsum = minsum + array[0, i];
  }
  for (int i = 1; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i, j];
    }
    if (minsum > sum)
    {
      minsum = sum;
      row = i;
    }
  }
  return row;
}