// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a<1000 && a>=99)
{
    Console.Write(a%10);
}
else if (a<=99)
{
    Console.Write("Третьей цифры в числе нет");
}
else if (a >= 1000 && a <= 9999)
{
    int b = a/10;
    Console.Write(b%10);
}
else if (a>=10000 && a<=99999)
{
    int c = a/100;
    Console.Write(c%10);
}

else 
{
    Console.Write("Дальше програмиист не осилил((");
}