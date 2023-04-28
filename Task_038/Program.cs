// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() *(max - min) + min;
    }
    return arr;
}

void PrintArray (double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1); 
        if(i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}

double FindCount(double[] arr)
{
    double min = 0;
    double max = 0;
    double minMax = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] > max)
       {
          max = arr[i];
       }
       if (arr[i] < min)
       {
          min = arr[i];
       }
       minMax = max - min;
    }
    double round = Math.Round(minMax, 1);
    return round;
}

double[] array = CreateArrayRndInt(5, 0, 10);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
double findCount = FindCount(array);
// double findCount = Math.Round(arr[i], 1);
Console.WriteLine($"Разница max, min = {findCount}");
