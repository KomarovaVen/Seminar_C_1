// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Print(int[,] arr_a)
{
    int row_size = arr_a.GetLength(0);
    int column_size = arr_a.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < arr_a.GetLength(1); j++)
            Console.Write($" {arr_a[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int row_num = arr.GetLength(0);
    int column_num = arr.GetLength(1);

    int[,] arr_a = new int[row, column];

    for (int i = 0; i < arr_a.GetLength(0); i++)
        for (int j = 0; j < arr_a.GetLength(1); j++)
            arr_a[i, j] = new Random().Next(from, to);
    return arr_a;
}
void Print1(int[,] arr_b)
{
    int row_size1 = arr_b.GetLength(0);
    int column_size1 = arr_b.GetLength(1);

    for (int i = 0; i < arr_b.GetLength(0); i++)
    {
        for (int j = 0; j < arr_b.GetLength(0); j++)
            Console.Write($" {arr_b[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums1(int row, int column, int from, int to)
{
    int row_size1 = arr_b.GetLength(0);
    int column_size1 = arr_b.GetLength(1);
    int[,] arr_b = new int[row, column];

    for (int i = 0; i < arr_b.GetLength(0); i++)
        for (int j = 0; j < arr_b.GetLength(1); j++)
            arr1[i, j] = new Random().Next(from, to);
    return arr_b;
}

string MatrixU(int[,] arr_a, int[,] arr_b)
{
    int a = 0;
    int b = 0;
    int[,] rez = new int[a, b];

    if (arr_a != arr_b) return "Matrix transposition is not possible";

    for (int i = 0; i < a; ++i)
    {
        for (int j = 0; j < b; ++j)
            for (int k = 0; k < b; k++)
                rez[i, j] += a[i, k] * b[k, j];

        Console.Write(rez);
    }

}

Console.Write("Введите количество строк в 1 массиве: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в 1 массиве: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Min значение в 1 массиве:");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Max значение в 1 массиве:");
int stop = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк во 2 массиве: ");
int row_num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во 2 массиве: ");
int column_num1 = int.Parse(Console.ReadLine()!);

Console.Write("Min значение во 2 массиве:");
int start1 = int.Parse(Console.ReadLine()!);
Console.Write("Max значение во 2 массиве:");
int stop1 = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
int[,] massiv = MassNums1(row_num, column_num, start, stop);
Print(mass);
Print1(massiv);
MatrixU(rez);