﻿//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.


Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
return Akkerman(m, n);
}

Console.WriteLine(Akkerman(m , n));



















