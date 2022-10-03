/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */

void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

double GetNumberFromUser(string userInformation)
{
    double result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!double.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число больше нуля. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

bool CheckFigureSide(double[] numbers, int sideIndex)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i != sideIndex) sum += numbers[i];
    }
    return sum > numbers[sideIndex];
}

bool CheckFigure(double[] figureSides)
{
    bool result = true;
    for (int i = 0; i < figureSides.Length; i++)
    {
        result = result && CheckFigureSide(figureSides, i);
    }
    return result;
}

double[] triangle = new double[3];
triangle[0] = GetNumberFromUser("Введите длину первой стороны");
triangle[1] = GetNumberFromUser("Введите длину второй стороны");
triangle[2] = GetNumberFromUser("Введите длину третьей стороны");

if (CheckFigure(triangle)) PrintInConsoleWithColor("Треугольник со сторонами такой длины существовать может", ConsoleColor.Green);
else PrintInConsoleWithColor("Треугольник со сторонами такой длины существовать не может", ConsoleColor.Red);
