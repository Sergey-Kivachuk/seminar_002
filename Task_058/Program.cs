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
 
void PrintMatrix1(int[,] matrix1)
{
    for (int i = 0; i <  matrix1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++) 
        {
            if (j < matrix1.GetLength(1) -1) Console.Write($"{matrix1[i, j], 3}");
            else Console.Write($"{matrix1[i, j], 3}");
        }
        Console.WriteLine(" |");        
    }        
}
 
void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i <  matrix2.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix2.GetLength(1); j++) 
        {
            if (j < matrix2.GetLength(1) -1) Console.Write($"{matrix2[i, j], 3}");
            else Console.Write($"{matrix2[i, j], 3}");
        }
        Console.WriteLine(" |");        
    }        
}

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    var matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (var i = 0; i < matrix1.GetLength(0); i++)
    {
        for (var j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            for (var k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix;
}
void PrintMatrix3(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 5}");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine(" |");        
    }        
}
int[,] array = CreateMatrix1(3, 3, 0, 9);
int[,] matrix = CreateMatrix2(3, 3, 0, 9);
PrintMatrix1(array);
Console.ReadLine();
PrintMatrix2(matrix);
Console.WriteLine();
int[,] result = DivMatrix(array,matrix);
PrintMatrix3(result);
Console.ReadLine();

