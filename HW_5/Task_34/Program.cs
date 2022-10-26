// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreatArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}
string GetArray(int[] array)
{
    string res = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res = res + $"{array[i]}, ";
    }
    return res;
}
int EvenElementsFromArray(int[] array)
{   int count = 0;
    for (int i = 0; i < array.Length; i++)
    {    
        if (array[i] % 2 == 0)
        count = count + 1;
    }
    return count;
}

int[] array = CreatArray(8, 100, 999);
Console.WriteLine(GetArray(array));
Console.WriteLine("Количество четных элементов в массиве = " + EvenElementsFromArray(array));
