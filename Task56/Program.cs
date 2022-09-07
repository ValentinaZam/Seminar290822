// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{

  int[,] matrix = new int[row, col];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++) // строки
  {
    for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
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
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(j < matrix.GetLength(1) - 1 ?
      $"{matrix[i, j],4}," : $"{matrix[i, j],4} ");
    }
    Console.WriteLine("]");
  }
}
int MinSumElement(int[,] matrix)
{
  int sum2 = 0;
  int row = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    sum2 += matrix[0, j];
  }
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int sum1 = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum1 += matrix[i, j];
    }
    if (sum1 < sum2)
    {
      row = i;
      sum2 = sum1;
    }
  }
  return row;
}
int[,] arr = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(arr);
int num = MinSumElement(arr);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {num + 1}");

