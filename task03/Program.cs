﻿int userNumber;
Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out userNumber))
{
    Console.Write("Нет, нужно ввести число! Повторите ввод: ");
}
for (int i = Math.Abs(userNumber) * (-1); i <= Math.Abs(userNumber); i++)
{
    Console.Write(i);
    Console.Write(" ");
}