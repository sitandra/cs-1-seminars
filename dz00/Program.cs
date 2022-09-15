int userNumber1, userNumber2;
Console.Write("a = ");
while (!int.TryParse(Console.ReadLine(), out userNumber1))
{
    Console.Write("Нет, нужно ввести число! a = ");
}
Console.Write("b = ");
while (!int.TryParse(Console.ReadLine(), out userNumber2))
{
    Console.Write("Нет, нужно ввести число! b = ");
}
Console.Write("max = ");
Console.Write(Math.Max(userNumber1, userNumber2));