// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень:");
int b = int.Parse(Console.ReadLine()!);
int res = 0;
var i = 1;


for (i = 1; i <= a; i++)
    res = a *= b;
Console.WriteLine(res);

