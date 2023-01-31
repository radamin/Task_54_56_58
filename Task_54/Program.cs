
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2




int[,] CreateMatrixRndInt(int rows, int columns, int minValue, int maxValue)
{
  int[,] newMatrix = new int[rows, columns];
  var rnd = new Random();
  for (int i = 0; i < newMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
      newMatrix[i, j] = rnd.Next(minValue, maxValue + 1);
    }
  }
  return newMatrix;
}

void PrintMatrix(int[,] matrix)
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


void SortRowsIntArray(int[,] intArray)
{
  for (int i = 0; i < intArray.GetLength(0); i++)
  {
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
      for (int k = j + 1; k < intArray.GetLength(1); k++)
      {
        if (intArray[i, j] < intArray[i, k])
        {
          int temp = intArray[i, j];
          intArray[i, j] = intArray[i, k];
          intArray[i, k] = temp;
        }
      }
    }
  }
}

Console.WriteLine();
Console.Write("Enter the number of rows of the array of random integers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Enter the number of columns of the array of random integers: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = CreateMatrixRndInt(row, column, 0, 9);
PrintMatrix(array);
Console.WriteLine();
SortRowsIntArray(array);
PrintMatrix(array);