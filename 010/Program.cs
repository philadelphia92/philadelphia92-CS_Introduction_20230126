// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры

int a,b;
Console.WriteLine("Введите значение числа a");
a = int.Parse(Console.ReadLine());
Console.WriteLine("a = {0,3}", +a);
b=a % 10;
Console.WriteLine("Последняя цифра числа {0,5}", +b);

