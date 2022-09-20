// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    return new Random().Next(minBorder, maxBorder + 1);
}
int number = getRandomNumberFromRange(100, 999);
Console.Write(number);
Console.Write(" -> ");
Console.WriteLine((number - number % 100) / 10 + number %10);