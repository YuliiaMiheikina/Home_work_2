﻿// Напишите программу, которая заполнит спирально массив 4 на 4.


void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int num = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = num++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = num++;
        for (k = 0; k < n - 1; k++) array[i, j--] = num++;
        for (k = 0; k < n - 1; k++) array[i--, j] = num++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int size = 4;
int[,] table = new int[size, size];
FillArraySpiral(table, size);
PrintArray(table);