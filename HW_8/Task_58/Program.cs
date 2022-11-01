/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}
int[,] ProductMatrix(int[,] matrixA, int[,] matrixB)
{
    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < matrixC.GetLength(0); i++)
        {
            for (int j = 0; j < matrixC.GetLength(1); j++)
            {
                matrixC[i, j] = 0;
                for (int n = 0; n < matrixA.GetLength(1); n++)
                {
                    matrixC[i, j] += matrixA[i, n] * matrixB[n, j];
                }
            }
        }
    }
    else
    {Console.WriteLine("Матрицы не согласованы, умножение невозможно!");}
    return matrixC;
}



int[,] matrixA = new int[3, 5];
int[,] matrixB = new int[5, 3];
GetArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
GetArray(matrixB);
PrintArray(matrixB);
Console.WriteLine();
PrintArray(ProductMatrix(matrixA,matrixB));
Console.ReadLine();





