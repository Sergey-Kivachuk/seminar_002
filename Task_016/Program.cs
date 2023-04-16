// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine ("ВВедите 1 число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("ВВедите 2 число ");
int numberB = Convert.ToInt32(Console.ReadLine());
bool result = IsSquare (numberA,numberB);
Console.WriteLine(result ? "да" : "нет");

bool IsSquare(int num1, int num2)
{
    return (num1 == num2 * num2) || (num2 == num1 * num1);
}