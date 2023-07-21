// 4. Напишите программу, которая на вход принимает два числа A и B,	
//    и возводит число А в целую степень B с помощью рекурсии.
Console.WriteLine("Введите a");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b");
int b = int.Parse(Console.ReadLine()!);
int Rec(int a, int b)
{
    if (b == 0) return 1;

    return Rec(a, b - 1) * a;
}
Rec(a, b);
Console.WriteLine($"{Rec(a, b)}");
