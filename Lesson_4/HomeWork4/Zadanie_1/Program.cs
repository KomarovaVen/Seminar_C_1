// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень:");
int b = int.Parse(Console.ReadLine()!);
int res = 0;
int i = 1;


for (i = 1; i <= b; i++)
    res = a * b;
{ Console.WriteLine(res); }
if (res == 0)
{ Console.WriteLine("Нельзя умножить на 0"); }
