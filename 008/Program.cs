// 8. Вывести на экран числа от -N до N
int N=3;
int i=-N;
Console.WriteLine("Введите число");
N=Convert.ToInt32(Console.ReadLine());

while(i<=N)
{
Console.WriteLine(i);
i=i+1;
}

