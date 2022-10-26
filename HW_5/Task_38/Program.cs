// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
double[] CreatArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.Next(0, 100) + rnd.NextDouble(), 2);
    }
    return array;
}

string GetArray(double[] array)
{
    string res = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res = res + $"{array[i]}  ";
    }
    return res;
}

double FindMin(double[] array)
{
    double min = double.MaxValue;
    for (int i = 0; i < array.Length; i++)

    {

        if (array[i] < min)
        {
            min = array[i];
        }

    }
    return min;

}

double FindMax(double[] array)
{
    double max = double.MinValue;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;

}


double[] array = CreatArray(10);
Console.WriteLine(GetArray(array));
Console.WriteLine($"Разница между max и min: " + (Math.Round((FindMax(array) - FindMin(array)), 2)));















