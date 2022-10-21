Console.WriteLine("Введите 5-значное число: ");
string number =(Console.ReadLine());
int length = number.Length;

if(length==5)
{
    if(number[0]==number[4] && number[1]==number[3])
    {
     Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число не палиндром");
    }
}
else
{
    Console.WriteLine("Недостаточно знаков в числе");
}
