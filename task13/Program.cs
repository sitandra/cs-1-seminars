// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

int getNumberFromUser(string userInformation)
{
    int result;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 1)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число больше единицы. {userInformation} ");
    }
    return result;
}

int[] tableQuarterNumber(int number)
{
    int[] result = new int [number];
    for(int i = 1; i <= number; i++)
    {
        result[i - 1] = (int)(Math.Pow(i, 2));
    }
    return result;
}


int number = getNumberFromUser("Введите целое число N > 1: ");
int[] table = tableQuarterNumber(number);

foreach (var value in table)
{
    Console.Write(value + " ");
}