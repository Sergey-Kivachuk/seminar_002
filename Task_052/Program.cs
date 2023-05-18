// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine(" |");
    }
}    

void PrintArif (int[,] matrix)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i,j;
    double sum = 0;
    for (i = 0; i < matrix.GetLength(1); i++)
    {
        for (j = 0; j < matrix.GetLength(0); j++)
        {
            sum +=  matrix[i, j];
        }
        sum = sum / matrix.GetLength(1);
        double round = Math.Round(sum, 1);
        Console.Write($"{round, 5} ");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
PrintArif(array2d);
// double arif = Arif(array2d);
// double round = Math.Round(matrix[, ], 1);
// Console.WriteLine($"Cумму элементов, находящихся на главной диагонали = {arif / matrix.GetLength(0)}");


// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m,n];

// void mas(int m, int n)
// {
//    int i,j;
//    Random rand = new Random();
//    for (i = 0; i < m; i++)
//    {
//        Console.WriteLine();
//        for (j = 0; j < n; j++)
//        {
//            randomArray[i,j] = rand.Next(1,9);
//            Console.Write($"{randomArray[i,j]} ");
//        }
//        Console.WriteLine();
//     }
// }

// void arif(int m, int n)
// {
//     Console.Write("Среднее арифметическое каждого столбца: ");
//     int i,j;
//     Random rand = new Random();
//     for (j = 0; j < n; j++)
//     {
//        double sum = 0;
//        for (i = 0; i < m; i++)
//        {
//            sum = sum + randomArray[i,j];
//        }
//        Console.Write($"{sum/(i):F1}" );
//     }
// }
// mas(m,n);
// arif(m,n);