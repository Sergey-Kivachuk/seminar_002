﻿// 30. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длину массива");
int lenghtArray = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(lenghtArray);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int [size];
    Random random = new Random(); // оптимизация объекта Random (var - объект неявной типизации)
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}