// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j],5} ");
}
Console.WriteLine();
}
}

int[] MatrixInArray(int[,] mtr)
{
int[] arr = new int[mtr.Length];
int x = 0;
for (int i = 0; i < mtr.GetLength(0); i++)
{
for (int j = 0; j < mtr.GetLength(1); j++)
{
arr[x] = mtr[i,j];
x++;
}
}
return ar
