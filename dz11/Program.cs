/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int getReadLineNumber(string message)
{
    int number;
    Console.Write($"{message}: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write($"Нет! {message}: ");
    }
    return number;
}
int? getDigitFromNumberOnPosition(int number, int digitPosition)
{
    int numberAbs = Math.Abs(number);
    int numberLength = numberAbs.ToString().Length;
    int? digit = null;
    if (digitPosition <= numberLength && digitPosition > 1)
    {
        digitPosition = numberLength - digitPosition; // Переворачиваем нумерацию, потому что отсчитывать будем с конца
        int currentPosition = 0;
        while (currentPosition <= digitPosition)
        {
            digit = numberAbs % 10;
            numberAbs = numberAbs / 10;
            currentPosition ++;
        }
    }
    return digit;
}
int number = getReadLineNumber("Введите число");
int digitPosition = 3;
int? digit = getDigitFromNumberOnPosition(number, digitPosition);
if (digit == null)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    Console.WriteLine($"{number} -> {digit}");
}