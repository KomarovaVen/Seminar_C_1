// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
//натуральные числа в промежутке от M до N с помощью рекурсии.
//Console.WriteLine("Hello, World!");

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
void Rez(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.Write($"{m}. ");
    }
    Rez(m + 1, n);

}
Rez(m, n);

