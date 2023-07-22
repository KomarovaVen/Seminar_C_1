// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
Sum(m, n);

void Sum(int m, int n)
{
    Console.Write(Summa(m - 1, n));
}

int Summa(int m, int n)
{
    int rez = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        rez = m + Summa(m, n);
        return rez;
    }
}
