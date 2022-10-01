
// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int FindSecondDigit(int num)
{
    int a = num % 100;
    int result = a / 10;
    
    return result;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondDigit = FindSecondDigit(num);

Console.WriteLine($"Second digit of {num} is {secondDigit}");
*/

// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool CheckNumber(int x)
{
    if((x==6)||(x==7))
        return true;
    else return false;
}

Console.Write("Введите число для проверки: ");
int x = Convert.ToInt32(Console.ReadLine());

bool result = CheckNumber(x);

if (result)
    Console.WriteLine($"День {x} является выходным");
else
    Console.WriteLine($"День {x} не является выходным");
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

bool FindThreeDigit(int num)
{
    if(num >= 100)
        return true;
    else return false;
}

Console.Write("Введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());

string str = Convert.ToString(num);
char threeDigit = str[2];

bool result = FindThreeDigit(num);
    
if (result)
    Console.WriteLine($"Третьей цифрой заданного числа {num} является {threeDigit}");
else
    Console.WriteLine($"Третьей цифры у заданного числа {num} нет");


// Второй вариант решения:
/*
int FindThreeDigit(int num)
{
    int result = num;
    if(num >= 100) result = num;
    else 
        Console.WriteLine($"Третьей цифры у заданного числа {num} нет");
    
    return result;
}

Console.Write("Введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = FindThreeDigit(num);

string str = Convert.ToString(result);
char threeDigit = str[2];
 
Console.WriteLine($"Третьей цифрой заданного числа {num} является {threeDigit}");
*/

