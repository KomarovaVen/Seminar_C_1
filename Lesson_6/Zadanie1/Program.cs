// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.


void ExiTri(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < b + a)
        Console.WriteLine("Треугольник существует.");
    else
        Console.WriteLine("Треугольник не существует.");
}

// 1 2 3, 4 2 5
Console.WriteLine("Введите a");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите c");
int c = int.Parse(Console.ReadLine()!);
ExiTri(a, b, c);