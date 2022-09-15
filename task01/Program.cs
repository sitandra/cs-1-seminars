int userNumber1, userNumber2;
Console.Write("Введите первое число, которое будем анализировать: ");
while (!int.TryParse(Console.ReadLine(), out userNumber1))
{
    Console.Write("Нет, нужно ввести число! Повторите ввод первого числа: ");
}
Console.Write("Введите второе число, которое будем анализировать: ");
while (!int.TryParse(Console.ReadLine(), out userNumber2))
{
    Console.Write("Нет, нужно ввести число! Повторите ввод второго числа: ");
}
if (userNumber1 == Math.Pow(userNumber2, 2))
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго");
}