Random rnd =new Random();
int number = (int)rnd.NextInt64(100, 999);
int First=0;
int Second=0;

Console.WriteLine(number);

First =number/10;
Second=First%10;

Console.WriteLine(Second);

//Random rnd =new Random();
//int number = (int)rnd.NextInt64(100, 999);
//string s = number.ToString();
//Console.WriteLine(s);
//Console.WriteLine(s[1].ToString());