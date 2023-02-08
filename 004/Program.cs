// 4.По заданному с клавиатуры номеру дня недели вывести его название
int a=0;
Console.Write("Введите день недели ");
a=Convert.ToInt32(Console.ReadLine());

if (a==1) 
Console.WriteLine ("Monday");

if (a==2) 
Console.WriteLine ("Tuesday");

if (a==3) 
Console.WriteLine ("Wednesday");

if (a==4) 
Console.WriteLine ("Thursday");

if (a==5) 
Console.WriteLine ("Friday");

if (a==6) 
Console.WriteLine ("Saturday");

if (a==7) 
Console.WriteLine ("Sunday");