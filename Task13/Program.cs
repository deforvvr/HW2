//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]

int a = int.Parse(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("Нет третьей цифры");
    return;
}

a = a % 100;
if (a == 0)
{
    Console.WriteLine("0");
    return;
}

a = a % 10;

Console.WriteLine(a);
