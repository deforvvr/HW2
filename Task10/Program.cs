﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int a = int.Parse(Console.ReadLine());
int b;

a = a % 100;
b = a / 10;

Console.WriteLine(b);
