int weekDay;
Console.Write("Введите номер дня недели: ");
while (!int.TryParse(Console.ReadLine(), out weekDay) || weekDay < 1 || weekDay > 7)
{
    Console.Write("Нет, нужно ввести число от 1 до 7! Повторите ввод номера дня недели: ");
}
string[] week = new string[7] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine(week[weekDay - 1]);