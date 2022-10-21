//int a = 3;
//int b = 7;
//int max = 0;
//int min = 0;
//if (a > b)
//{
  // max = a;
   //min = b; 
//}
//else 
//{
   // max = b;
   // min = a;
//}
//Console.WriteLine("max: "+ max  + "min: "+ min);



Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;

 if (a > b)
 {
    max = a;
    min = b;
}
 else
 {
    min = a;
    max = b;
 }
Console.WriteLine("max: "+ max + "min: "+ min);