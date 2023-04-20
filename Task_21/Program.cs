﻿// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A ");
Console.Write("Xa: ");
int XaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int YaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Za: ");
int ZaCoordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");
Console.Write("Xb: ");
int XbCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int YbCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb: ");
int ZbCoordinate = Convert.ToInt32(Console.ReadLine());

double distanceABZ = DistanceABZ( XaCoordinate, YaCoordinate, ZaCoordinate, XbCoordinate, YbCoordinate, ZbCoordinate );
double distRound = Math.Round (distanceABZ, 2, MidpointRounding.ToZero);
Console.WriteLine(distRound);

double DistanceABZ(int xa, int ya, int xb, int yb, int za, int zb)
{
   int deltaX = xa - xb;
   int deltaY = ya - yb;
   int deltaZ = za - zb;
   double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
   return distAB ;
}
