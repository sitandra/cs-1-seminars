/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

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
    while (!double.TryParse(Console.ReadLine(), out result))
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}
double[] GetCrossPoint(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    return point;
}

PrintInConsoleWithColor("y1 = k1 * x + b1", ConsoleColor.Green);
Console.WriteLine();
PrintInConsoleWithColor("y2 = k2 * x + b2", ConsoleColor.Green);
Console.WriteLine();
double b1 = GetNumberFromUser("Введите b1");
double k1 = GetNumberFromUser("Введите k1");
double b2 = GetNumberFromUser("Введите b2");
double k2 = GetNumberFromUser("Введите k2");
double[] crossPoint = GetCrossPoint(b1, k1, b2, k2);

PrintInConsoleWithColor($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ", ConsoleColor.Green);
if (Double.IsNaN(crossPoint[0])) PrintInConsoleWithColor($"прямые не пересекаются", ConsoleColor.Red);
else PrintInConsoleWithColor($"({Math.Round(crossPoint[0], 2)}; {Math.Round(crossPoint[1], 2)})", ConsoleColor.Green);
Console.WriteLine();