// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. 
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается целое число. {userInformation}: ");
    }
    return result;
}

double findRangeBetweenTwoPoints(int coordinateX1, int coordinateY1, int coordinateX2, int coordinateY2)
{
    return Math.Round(Math.Sqrt(Math.Pow(coordinateX2 - coordinateX1, 2) + Math.Pow(coordinateY2 - coordinateY1, 2)), 3);
}

int userCoordinateX1 = getCoordinateFromUser("X1 = ");
int userCoordinateY1 = getCoordinateFromUser("Y1 = ");
int userCoordinateX2 = getCoordinateFromUser("X2 = ");
int userCoordinateY2 = getCoordinateFromUser("Y2 = ");
double range = findRangeBetweenTwoPoints(userCoordinateX1, userCoordinateY1, userCoordinateX2, userCoordinateY2);

Console.WriteLine($"A ({userCoordinateX1}, {userCoordinateY1}); B ({userCoordinateX2}, {userCoordinateY2}) -> {range}");
