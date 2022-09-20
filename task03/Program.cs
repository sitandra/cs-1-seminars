/* 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
int userNumber;
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