/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Введите числа через пробел: ");
string? inputText = Console.ReadLine();
Console.Write(inputText.Split(" ").Select(it => int.Parse(it)).Max());