// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] matrixA = CreateMatrixRndInt(3, 3, 0, 9);
int[,] matrixB = CreateMatrixRndInt(3, 3, 0, 9);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);


void MultiplyMatrix(int[,] arr1, int[,] arr2)
{
if (arr1.GetLength(1) != arr2.GetLength(0)) 
Console.WriteLine("Матрицы нельзя перемножить");
int[,] matrixC = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                matrixC[i,j] += arr1[i,k] * arr2[k,j];
                        
            }
        }
    } 
Console.WriteLine();
PrintMatrix(matrixC);
return;
}

MultiplyMatrix(matrixA, matrixB);



// if (matrixA.GetLength(1) != matrixB.GetLength(0)) 
// Console.WriteLine("Матрицы нельзя перемножить");
// int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixB.GetLength(0); k++)
//             {
//                 matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
                        
//             }
//         }
//     }

// Console.WriteLine();
// PrintMatrix(matrixC);