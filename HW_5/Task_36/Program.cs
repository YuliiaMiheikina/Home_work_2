// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
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
        res = res + $"{array[i]} ";

    }
    return res;
}

int GetSumOddIndex(int[] array)
{
    int sum  = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + array[i];
    }
    return sum;
}

int[] array= CreatArray(8,1,10);
Console.WriteLine(GetArray(array));
Console.WriteLine(GetSumOddIndex(array));
