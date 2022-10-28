//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
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

void AverageColumn(int[,] array)
{   
     
    for (int j = 0; j< array.GetLength(1); j++)
    {   
        double sum = 0;
        for (int i = 0; i< array.GetLength(0); i++)
        {
            sum = (double)sum +array[i,j];

        }
        Console.Write($"{sum/array.GetLength(0)}  ");
    }
    
   
}
int[,] array = GetArray(m,n);
PrintArray(array);
Console.WriteLine();
AverageColumn(array);
