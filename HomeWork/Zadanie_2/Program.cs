// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Write a number 1: ");
string s_a = Console.ReadLine()!;
Console.WriteLine("Write a number 2: ");
string s_b = Console.ReadLine()!;
Console.WriteLine("Write a number 3: ");
string s_c = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);

int[] ar = { a, b, c };
int maxValue = ar.Max<int>();
Console.WriteLine(maxValue);


