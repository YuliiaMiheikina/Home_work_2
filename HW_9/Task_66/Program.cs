//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

void GetNumbers(int M,int N)
{
    if(M<=N)
    {
        if (M==N) 
        { Console.WriteLine(M);
        return;}
        else 
        {
            Console.WriteLine(M);
            M=M+1;
            GetNumbers(M,N);
        }
    }
    else Console.WriteLine($"M должно быть меньше N!");
}
GetNumbers(M,N);
Console.WriteLine();


void SumNumbers(int M, int N,int sum)
{
    
    if (M > N)
    {
        Console.WriteLine(sum);
        return;
    }
    else
    {   
        sum = sum + M;
        SumNumbers(M+1,N,sum);
    }
}
SumNumbers(M, N,0);