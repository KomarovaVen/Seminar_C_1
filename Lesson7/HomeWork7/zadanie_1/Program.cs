// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.


void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        { System.Console.Write($"{matr[i, j]} ") /; }
        System.Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble();
        }
    }
}

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
//System.Console.WriteLine(FindNum(matrix, a));