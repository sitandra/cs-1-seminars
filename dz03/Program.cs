/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
int userNumber;
Console.Write("Введите целое число больше 1: ");
while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1)
{
    Console.Write("Нет, нужно ввести целое число больше 1! Повторите ввод: ");
}
for (int i = 2; i <= userNumber; i ++)
{
    if (i % 2 == 0)
    {
        if (i > 2)
        {
            Console.Write(", ");
        }
        Console.Write(i);
    }
}