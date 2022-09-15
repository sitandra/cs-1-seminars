int userNumber;
Console.Write("Введите целое число больше 1: ");
while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1)
{
    Console.Write("Нет, нужно ввести целое число больше 1! Повторите ввод: ");
}
bool flag = false;
for (int i = 1; i <= userNumber; i ++)
{
    if (i % 2 == 0)
    {
        if (flag)
        {
            Console.Write(", ");
        }
        else
        {
            flag = true;
        }
        Console.Write(i);
    }
}