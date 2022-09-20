// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
int number = new Random().Next(100, 999);
Console.Write(number);
Console.Write(" -> ");
Console.WriteLine((number - number % 100) / 10 + number %10);