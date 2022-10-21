//int a = 1;
//int b = 100;
//int c = 54 ;
//int max = a;


 //if (b > max)
//{
    //max = b;
//}
 //if(c > max)
 //{
   // max = c;
 //}
//Console.WriteLine(max);

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;


 if (b > max)
{
    max = b;
}
 if(c > max)
 {
    max = c;
 }
Console.WriteLine(" max=" + max);

