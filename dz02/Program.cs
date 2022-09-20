/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
int userNumber;
Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out userNumber))
{
    Console.Write("Нет, нужно ввести целое число! Повторите ввод: ");
}
if (userNumber % 2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}