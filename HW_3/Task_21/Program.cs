// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*int[,] array= new int [2,3];
Console.WriteLine("Введите координату x1: ");
array[0,0] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
array[0,1] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
array[0,2] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
array[1,0] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
array[1,1] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
array[1,2] = int.Parse(Console.ReadLine());

double result=Math.Sqrt(Math.Pow((array[0,0]-array[1,0]),2)+Math.Pow((array[0,1]-array[1,1]),2)+Math.Pow((array[0,2]-array[1,2]),2));
Console.WriteLine(result); */


























Console.WriteLine("Введите координаты первой точки: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int[] p1 = new int[] {x1, y1, z1};
Console.WriteLine("Введите координаты второй точки: ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
int[] p2 = new int[] {x2, y2, z2};

double result = Math.Sqrt(Math.Pow((p1[0]-p2[0]),2))+ Math.Pow((p1[1]-p2[1]),2) + Math.Pow((p1[2]-p2[2]),2);

Console.WriteLine(result);

