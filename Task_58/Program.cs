// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.


Console.Write("Enter the number of rows for the first array: ");
int firstRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns for the first array: ");
int firstColumn = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns for the second array: ");
int secondColumn = Convert.ToInt32(Console.ReadLine());
int secondRow = firstColumn;

int[,] CreateMatrixAverageInt(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write(' ');
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}\t ");
      else Console.Write($"{matrix[i, j],3}\t ");
    }
    Console.WriteLine();
  }
}

int[,] MatrixMultiplication(int[,] arrayOne, int[,] arrayTwo)
{
  int firstRows = arrayOne.GetLength(0);
  int firstCols = arrayOne.GetLength(1);
  int secondRows = arrayTwo.GetLength(0);
  int secondCols = arrayTwo.GetLength(1);
  int[,] multiplication = new int[firstRows, secondCols];
  for (int i = 0; i < firstRows; i++)
  {
    for (int j = 0; j < secondCols; j++)
    {
      for (int k = 0; k < firstCols; k++)
      {
        multiplication[i, j] += arrayOne[i, k] * arrayTwo[k, j];
      }
    }
  }
  return multiplication;
}


int[,] matrixFirst = CreateMatrixAverageInt(firstRow, firstColumn, 1, 9);
PrintMatrix(matrixFirst);
Console.WriteLine();
int[,] matrixSecond = CreateMatrixAverageInt(secondRow, secondColumn, 1, 9);
PrintMatrix(matrixSecond);
Console.WriteLine();
int[,] matrixmultiplication = MatrixMultiplication(matrixFirst, matrixSecond);
PrintMatrix(matrixmultiplication);


