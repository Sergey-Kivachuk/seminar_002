// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


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

void EvenElements(int[,] matrix,int a, int b )
{
    if ( a > matrix.GetLength(0)-1  &&  b > matrix.GetLength(1)-1)
    {
        Console.WriteLine("Такого элемента не существует");
    }
    else
    {    
        Console.WriteLine($"Значение элемента массива = { matrix[a,b]}");
    }
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
Console.Write("Введите строку: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
EvenElements(array2d, a, b);
Console.WriteLine();