// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int getQuarterFromCoordinate(int coordinateX, int coordinateY)
{
    int result = 0;
    if (coordinateX > 0 && coordinateY > 0)
    {
        result = 1;
    } else if (coordinateX > 0 && coordinateY < 0)
    {
        result = 2;
    } else if (coordinateX < 0 && coordinateY < 0)
    {
        result = 3;
    } else if (coordinateX < 0 && coordinateY > 0)
    {
        result = 4;
    }
    return result;
}
int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation}: ");
    while (!int.TryParse(Console.ReadLine(), out result) || result == 0)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число, которое не равно 0. {userInformation}: ");
    }
    return result;
}
int userCoordinateX = 0;
int userCoordinateY = 0;
Console.WriteLine("Введите координаты");
userCoordinateX = getCoordinateFromUser("X = ");
userCoordinateY = getCoordinateFromUser("Y = ");
int quarter = getQuarterFromCoordinate(userCoordinateX, userCoordinateY);
if (quarter > 0)
{
    Console.WriteLine($"Точка с координатами [{userCoordinateX}:{userCoordinateY}] находится в {quarter} четверти плоскости");
} else {
    Console.WriteLine($"Одна из координат равна нулю, нельзя определить чертверть плоскости точки [{userCoordinateX}:{userCoordinateY}]");
}