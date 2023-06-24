// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");
string s_n = Console.ReadLine()!;

int n = int.Parse(s_n);


for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);


//while (m <= n)
//{
//    Console.Write($"{m} ")!;
//    m += 1;
// }
//break;




