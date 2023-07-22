// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9
//    https://metanit.com/sharp/tutorial/4.9.php

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

int[,] MatProd(int[,] arr_first, int[,] arr_second)
{
    int row_size = arr_first.GetLength(0);
    int column_size = arr_first.GetLength(1);
    int[,] pr_matrix = new int[row_size, column_size];

    if (row_size != arr_second.GetLength(0) || column_size != arr_second.GetLength(1)) return pr_matrix;

    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
            pr_matrix[i, j] = arr_first[i, j] * arr_second[i, j];
    return pr_matrix;
}



Console.Write("Введите количество строк 1 матрицы:  ");
int row_num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 матрицы: ");
int column_num_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк 2 матрицы:  ");
int row_num_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 матрицы: ");
int column_num_2 = int.Parse(Console.ReadLine()!);

Console.Write("Min значение в массиве:");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Max значение в массиве:");
int stop = int.Parse(Console.ReadLine()!);

int[,] arr_1 = MassNums(row_num_1, column_num_1, 0, 5);
Print(arr_1);
int[,] arr_2 = MassNums(row_num_2, column_num_2, 0, 5);
Print(arr_2);

int[,] res_matrix = MatProd(arr_1, arr_2);
Print(res_matrix);



