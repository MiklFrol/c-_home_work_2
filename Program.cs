// Программа принимает трехзначное число, и выдает вторую цыфру данного числа

Console.Clear();

Repeat:

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

if (number > 99 && number < 1000)
{ 
int tempDigit = number / 10 ;
int secondDigit = tempDigit % 10;
Console.WriteLine ($"Для числа {number} второй цифрой является {secondDigit}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
    goto Repeat;
}