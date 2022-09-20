// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет
bool isSquare(int firstNumber, int secondNumber)
{
    return firstNumber / secondNumber == secondNumber;
}

int number1, number2;
Console.Write("Введите первое целое число: ");
while(!int.TryParse(Console.ReadLine(), out number1))
{
    Console.Write("Нет, введите первое целое число: ");
}
Console.Write("Введите второе целое число: ");
while(!int.TryParse(Console.ReadLine(), out number2))
{
    Console.Write("Нет, введите второе целое число: ");
}
Console.Write(number1);
Console.Write(", ");
Console.Write(number2);
if (isSquare(number1, number2) || isSquare(number2, number1))
{
    Console.Write(" -> да");
}
else
{
    Console.Write(" -> нет");
}