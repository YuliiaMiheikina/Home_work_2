//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSumRow (int[,] array)
{   
    int MinSumRow  = 0;
    int sumRow = 0;
    int minRow = 0;
for (int i = 0; i< array.GetLength(1); i++)
    {   
        minRow = minRow + array[0,i];
    }
for (int i = 0; i< array.GetLength(0); i++)
        {
           for(int j = 0; j< array.GetLength(1); j++)
           {
            sumRow = sumRow + array[i,j];
           }
           if(sumRow < MinSumRow )
           {
            MinSumRow  = sumRow;
            minRow = i;
           }
            sumRow = 0;
        }
        Console.Write($"Наименьшая сумма элементов в строке {(minRow)+ 1}");
    }
    
   

int[,] array = GetArray(3,4);
PrintArray(array);
MinSumRow(array);
