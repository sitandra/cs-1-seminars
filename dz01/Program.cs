Console.Write("Введите числа через пробел: ");
string? inputText = Console.ReadLine();
Console.Write(inputText.Split(" ").Select(it => int.Parse(it)).Max());