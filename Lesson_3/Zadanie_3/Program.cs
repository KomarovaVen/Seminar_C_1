// See https://aka.ms/new-console-template for more information
void Squares(int num)
{
    int i = 1;
    Console.Write($"{num} -> ");

    while (num >= i)
    {
        Console.Write($"{Math.Pow(i, 2)}, ");
        i++;
    }
    Console.WriteLine();
}

int num = int.Parse(Console.ReadLine()!);
Squares(num);
