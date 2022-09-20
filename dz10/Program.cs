/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */
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
int digitPosition = 2;
int? digit = getDigitFromNumberOnPosition(number, digitPosition);
if (digit == null)
{
    Console.WriteLine($"В числе {number} нет цифры в позиции {digitPosition}");
}
else
{
    Console.WriteLine($"{number} -> {digit}");
}