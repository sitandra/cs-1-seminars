/* 0 Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/
Console.Write("Введите число: ");
int userNumber;
if (int.TryParse(Console.ReadLine(), out userNumber)) // Convert.ToInt32();
{
    Console.WriteLine(Math.Pow(userNumber, 2));
}
else
{
    Console.WriteLine("Нужно ввести число");
}