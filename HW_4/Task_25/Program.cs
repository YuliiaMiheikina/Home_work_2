//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A: ");
double A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
double result = 1;
for(int i=1;i<=B;i++)

{result=result*A;}

 Console.WriteLine(result);

