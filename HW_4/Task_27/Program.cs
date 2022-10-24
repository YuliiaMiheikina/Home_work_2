// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int Numbers(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;

    }
    return result;
}

void GetSum(int number)
{
    int newnum = number;
    int result = Numbers(number);
}

Console.WriteLine(Numbers(number));



/*int NumberLength(int number)
{
    int Length = 0;

    while (number != 0)
    {
        number = number / 10;
        Length++;
    }
    return Length;

}
Console.WriteLine(NumberLength(number));*/











/*Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
string str = n.ToString();
int[] b = new int[str.Length];
int result = 0;
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
     result = result + b[i];
}
Console.WriteLine(result);*/


