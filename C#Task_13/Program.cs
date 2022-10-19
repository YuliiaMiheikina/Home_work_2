Random rnd =new Random();
int number = (int)rnd.NextInt64();
//int number =25;
string s = number.ToString();
Console.WriteLine(s);

if(number>99)
{
    Console.WriteLine(s[2].ToString());
}
if (number<-99)
{
    Console.WriteLine(s[3].ToString());
}
else
{
   Console.WriteLine("Такой цифры нет!");
}