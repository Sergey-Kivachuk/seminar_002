﻿//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());
int functionAkkerman = Ack(numberM, numberN);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0) return Ack(numberM - 1, 1);
    else return Ack(numberM - 1, Ack(numberM, numberN - 1));
}
