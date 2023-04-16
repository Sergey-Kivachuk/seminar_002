// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int numberA = new Random().Next(1, 99);
Console.WriteLine($"Случайное первое число  -> {numberA} ");
int numberB = new Random().Next(1, 99);
Console.WriteLine($"Случайное второе  число  -> {numberB} "); 
int result = Remainde(numberA, numberB);

// if (result == 0 )
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine($"не кратно, остаток {result}");
// }

string res = (result == 0) ? "кратно" : $"не кратно, остаток {result}";
Console.Write(res);
int Remainde (int numA, int numB) 
{
    return numA % numB ; 
 }


