// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrixRndInt(int row, int col, int num) 
{    
    int[,,] matrix = new int[row,col,num];
    
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (count > 99) break;
                matrix[i, j, k] = count++;
            }
        }
    }
    return matrix;
} 
int[,,] matrix3D = CreateMatrixRndInt(3, 3, 3);

void Print3DMatrix(int[,,] matrix) 
{    
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
              Console.WriteLine($"{matrix[i,j,k]} ({i},{j},{k})");
            }
        }
    }
} 

Print3DMatrix(matrix3D);