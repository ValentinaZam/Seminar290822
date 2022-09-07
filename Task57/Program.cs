// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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



int[] ArrayCompl(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i,j];
            count++;
        }
    }
    return array;
}

void SumElem(int[] array)
{
    int number = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} : {count}");
            number = array[i];
            count = 1;
        }
        if (i == array.Length - 1) Console.WriteLine($"{number} : {count}");
    }
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 5);
PrintMatrix(matrix);
int[] arr = ArrayCompl(matrix);
Array.Sort(arr);
PrintMatrix(matrix);
SumElem(arr);


// Дорабоать
