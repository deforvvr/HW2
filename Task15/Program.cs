//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int a = int.Parse(Console.ReadLine());

if (a > 7)
{
    Console.WriteLine("Ошибка");
    return;
}

if (a == 6 || a == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Не выходной");
}
