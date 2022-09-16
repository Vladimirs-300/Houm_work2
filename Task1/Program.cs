// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 1000);
System.Console.WriteLine();
System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");
