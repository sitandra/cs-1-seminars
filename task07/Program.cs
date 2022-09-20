// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно
int divisibleNumber, divisor, remainder;
Console.Write("Введите делимое (целое число): ");
while (!int.TryParse(Console.ReadLine(), out divisibleNumber))
{
    Console.Write("Нет, введите делимое (целое число): ");
}
Console.Write("Введите делитель (целое число): ");
while (!int.TryParse(Console.ReadLine(), out divisor))
{
    Console.Write("Нет, введите делитель (целое число): ");
}
Console.Write(divisibleNumber);
Console.Write(", ");
Console.Write(divisor);
Console.Write(" -> ");
if ((remainder = divisibleNumber % divisor) == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.Write("не кратно, остаток ");
    Console.WriteLine(remainder);
}