// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Write a number : ");
string s_a = Console.ReadLine()!;

int a = int.Parse(s_a);

if ((a % 2) == 0)
{
    Console.WriteLine("chentoe");
}
else
{
    Console.WriteLine("nechentoe");
}
