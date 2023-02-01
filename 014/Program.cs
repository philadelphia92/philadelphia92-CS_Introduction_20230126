// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int remainder;
Console.WriteLine("Введите число a");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b=int.Parse(Console.ReadLine());
remainder=a%b;
if(remainder !=0)
{
    Console.WriteLine($"{remainder} - делится с остатком. Остаток:");

}
Console.WriteLine((double)a/(double)b);
