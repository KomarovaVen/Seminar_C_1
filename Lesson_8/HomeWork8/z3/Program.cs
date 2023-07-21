// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Print(int[,] arr)
{
    int row_size = A.GetLength(0);
    int column_size = A.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixA(int row, int column, int from, int to)
{
    int[,] A = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            A[i, j] = new Random().Next(from, to);
    return A;
}
void Print1(int[,] arr1)
{
    int row_size1 = B.GetLength(0);
    int column_size1 = B.GetLength(1);

    for (int i = 0; i < row_size1; i++)
    {
        for (int j = 0; j < column_size1; j++)
            Console.Write($" {arr1[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixB(int row1, int column1, int from, int to)
{
    int[,] arr1 = new int[row1, column1];

    for (int i = 0; i < row1; i++)
        for (int j = 0; j < column1; j++)
            arr1[i, j] = new Random().Next(from, to);
    return arr1;
}

void Matrix(int[,] a, int[,] b)
{
    A = a;
    B = b;
}
bool CheckMatrix()
{
    if (A.GetLength(1) != B.GetLength(0))
    {
        Console.WriteLine("Матрицы перемножить нельзя.");
        return false;
    }
    else
        return true;
}

int Multiply(int[,] rez)
{
    int[,] rez = new int[A.GetLength(0), B.GetLength(0)];

    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < B.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < A.GetLength(0); k++)
            {
                sum += A[i, k] * B[k, j];
            }
            rez[i, j] = sum;
        }
    }
    return rez;
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

int[,] A = MatrixA(row_num, column_num, start, stop);
int[,] B = MatrixB(row_num1, column_num1, start1, stop1);
double[,] massiv2 = RezMatr();
Print(A);
Print1(B);
Multiply(rez);