// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
{    
    int[,] matrix = new int[row,col];
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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4},");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D= CreateMatrixRndInt(2, 5, 1, 22);
PrintMatrix(array2D);

void ArrangeMatrix(int[,] matrix)
{
  for (int k = 0; k < matrix.GetLength(0); k++)
  {
    for (int i = 0; i < matrix.GetLength(1)-1; i++)
    {
      int index = i;
      int max = matrix[k,i];
      for (int j = i+1; j < matrix.GetLength(1); j++)
      {
        if (max < matrix[k,j])
        {
          max = matrix[k,j];
          index = j;
        }
      }
      int temp = matrix[k,index];
      matrix[k,index] = matrix[k,i];
      matrix[k,i] = temp;
    }
  }
}

Console.WriteLine();
ArrangeMatrix(array2D);
PrintMatrix(array2D);

// for (int i = 0; i < array2D.GetLength(0); i++)
// {
//   for (int j = 0; j < array2D.GetLength(1); j++)
//   {



//     int max = array2D[0, 0];
//     int j = 1;
//     while(j < array2D.GetLength(1))
//     {       
//     if (max < array2D[0, j])     
//        max = array2D[0, j];       
//       j++;     
//     }
//     Console.Write(max);

//   int temp = max;



// int max = array2D[0, 0];
// for (int j = 0; j < array2D.GetLength(1); j++)
// {
//     if (max < array2D[0, j])
//         max = array2D[0, j];

// }
// Console.WriteLine($"{max}");

// int i = 0;
// for (i = 0; i < array2D.GetLength(1); i++)
// {
//     if (array2D[0, i] == max) break;
// }
// Console.WriteLine($"{i}");

// int temp = array2D[0, 0];
// array2D[0, 0] = array2D[0, i];
// array2D[0, i] = temp;


// PrintMatrix(array2D);

