//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreatArray(int m,int n)
{
    int[,] array = new int [m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    
}
int[,] array = CreatArray(6,6);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите номер строки: ");
int r = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int c = int.Parse(Console.ReadLine());

void FindElement(int[,] array)
{
    if (r <= array.GetLength(0) && c <= array.GetLength(1) )
    {
        Console.WriteLine($"В данной ячейке значение: {array[r-1,c-1]} ");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }

}


FindElement(array);