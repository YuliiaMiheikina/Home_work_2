// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("enter x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("enter y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("enter z: ");
int z = int.Parse(Console.ReadLine());


int[,,] Creat3DArray(int x, int y,int z)
{
    int[,,] array = new int[x, y, z];
    
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
            for (int k = 0; k < array.GetLength(2); k++)

            {
                array[i, j, k] = rnd.Next(10,99);
                int unic = array[i, j, k];
                int w = 0;
                if (w ==unic)
                    break;
                if (w != unic)
                unic= w;
            }
            }
    }
return array;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{array[i, j, k]} {(i,j,k)} ");
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] newarray = Creat3DArray(x,y,z);
PrintArray(newarray);


