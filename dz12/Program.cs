/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int getReadLineWeekDayNumber()
{
    int number;
    string message = "Введите номер дня недели (1 – 7)";
    Console.Write($"{message}: ");
    while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 7)
    {
        Console.Write($"Нет! {message}: ");
    }
    return number;
}

bool isWeekend(int weekDayNumber)
{
    int[] weekends = {6, 7};
    return weekends.Contains(weekDayNumber);
}

int weekDayNumber = getReadLineWeekDayNumber();
if (isWeekend(weekDayNumber))
{
    Console.WriteLine($"{weekDayNumber} -> да");
}
else
{
    Console.WriteLine($"{weekDayNumber} -> нет");
}