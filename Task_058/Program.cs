// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrix1 (int row, int col, int min, int max) 
{
    int[,] matrix1 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix1;
} 
 
int[,] CreateMatrix2 (int row, int col, int min, int max) 
{
    int[,] matrix2 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix2.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix2;
} 
 
void PrintMatrix1(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 3}");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine(" |");        
    }        
}
 
void PrintMatrix2(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 3}");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine(" |");        
    }        
}

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int aRows = matrix1.GetLength(0);
    int aCols = matrix1.GetLength(1);
    int bRows = matrix2.GetLength(0);
    int bCols = matrix2.GetLength(1);
    if (aCols != bRows)
    {    
        int[,] newMatrix = new int[aRows, bCols];
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        { 
            for (int j = 0; j < newMatrix.GetLength(1); j++) 
            {
                for (int k = 0; k < aCols; k++)
                {
                    newMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
                }
                return newMatrix;    
            }
        }
    }  
}
 
int[,] array2D = CreateMatrix1(2, 2, 0, 9);
int[,] matrix = CreateMatrix2(2, 2, 0, 9);
PrintMatrix1(array2D);
// Console.WriteLine();
PrintMatrix2(array2D);
int[,] newMatrix = DivMatrix (matrix1, matrix2);
PrintMatrix2(newMatrix);