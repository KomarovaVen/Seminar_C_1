// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        { System.Console.Write($"{matr[i, j]} "); }
        System.Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        { matr[i, j] = new Random().Next(1, 10); }
    }
}

void Sum_massive(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("не будет ровной диагонали");
        return;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j];
            }
        }
    }
    Console.Write($"{sum}");
}
Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
Sum_massive(matrix);
//PrintArray(matrix);
