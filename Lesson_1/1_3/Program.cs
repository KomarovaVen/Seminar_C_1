// 3. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.

// --------------------------------------- вариант 1

string s_N = Console.ReadLine()!;
int N = int.Parse(s_N);
int m = -N;

while (m <= N)
{
    Console.Write($"{m} ");
    m += 1;
}


// --------------------------------------- вариант 2

int N = int.Parse(Console.ReadLine()!);
int m = -N;

while (m != N)
{
    Console.Write($"{m} ");
    if (N > 0) m += 1;
    else m -= 1;
}
Console.Write($"{m} ");

