// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да
bool isMultiple(int divisibleNumber, int divisor)
{
    return divisibleNumber % divisor == 0;
}

int number;
Console.Write("Введите целое число: ");
while(!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Нет, введите целое число: ");
}
Console.Write(number);
if (isMultiple(number, 7) && isMultiple(number, 23))
{
    Console.Write(" -> да");
}
else
{
    Console.Write(" -> нет");
}