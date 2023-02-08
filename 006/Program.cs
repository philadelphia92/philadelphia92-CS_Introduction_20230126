// 6. Написать программу вычисления значения функции y = sin(a)

Console.Write("Вычисление sin(a)\nУгол в градусах = ");
double x = Convert.ToDouble(Console.ReadLine());
double a, b;
a = x*Math.PI/180;
Console.WriteLine("Угол в радианах ={0}", a);
b=Math.Sin(a);
Console.WriteLine("sin({0})={1}",a,b);

