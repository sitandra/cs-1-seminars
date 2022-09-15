Console.Write("Введите число: ");
int userNumber;
if (int.TryParse(Console.ReadLine(), out userNumber))
{
    Console.WriteLine(Math.Pow(userNumber, 2));
}
else
{
    Console.WriteLine("Нужно ввести число");
}