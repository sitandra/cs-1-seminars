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