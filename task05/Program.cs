// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 78 -> 8 12-> 2 85 -> 8
int number = new Random().Next(10, 99);
int number1 = number % 10;
int number2 = (number - number1) / 10;
Console.Write(number);
Console.Write(" -> ");
Console.WriteLine(Math.Max(number1, number2));