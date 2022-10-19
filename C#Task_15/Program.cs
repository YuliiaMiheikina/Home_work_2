Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота-ВЫХОДНОй!"); break;
    case 7: Console.WriteLine("Воскресенье-ВЫХОДНОЙ!"); break;
}