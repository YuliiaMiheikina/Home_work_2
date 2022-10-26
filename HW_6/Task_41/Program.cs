//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел: ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
}

int FindCountElements(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"Кол-во элементов > 0: " + (FindCountElements(numbers)));


