// Программа проверяет пятизначное число на палиндромом. Например: 123321

System.Console.Write("Введите пятизначное число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

System.Console.WriteLine("Ответ:");
if (IsPalindrome()) System.Console.WriteLine($"Число - {number} - является палиндромом");
else System.Console.WriteLine($"Число {number} не является палиндромом");