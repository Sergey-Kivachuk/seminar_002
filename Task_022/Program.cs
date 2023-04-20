// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void TableAllSquares(int num)
{
   int index = 1;
   while (index <= num)
   {
     Console.WriteLine($"{index, 3} {index * index, 4}"); // ,3 растояние 
     index++;
   }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableAllSquares(number);