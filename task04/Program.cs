// Выводит последнюю цифру введенного трехзначного числа
int userNumber;
Console.Write("Введите целое трехзначное число: ");
while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 100 || userNumber > 999)
{
    Console.Write("Нет, нужно ввести целое трехзначное число! Повторите ввод: ");
}
Console.WriteLine(userNumber % 10);