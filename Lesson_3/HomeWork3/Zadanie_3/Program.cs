﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3-> 1, 8, 27
// 5-> 1, 8, 27, 64, 125

void Chislo(int num)
{
    int i = 1;
    Console.Write($"{num} -> ");

    while (num >= i)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
        i++;
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
Chislo(num);