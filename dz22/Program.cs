/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 
*/

int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается целое число. {userInformation} ");
    }
    return result;
}

double findRangeBetweenTwoPoints(int coordinateX1, int coordinateY1, int coordinateZ1,
                                 int coordinateX2, int coordinateY2, int coordinateZ2)
{
    return Math.Round(Math.Sqrt(Math.Pow(coordinateX2 - coordinateX1, 2) + Math.Pow(coordinateY2 - coordinateY1, 2) + Math.Pow(coordinateZ2 - coordinateZ1, 2)), 2);
}

int userCoordinateX1 = getCoordinateFromUser("Xa =");
int userCoordinateY1 = getCoordinateFromUser("Ya =");
int userCoordinateZ1 = getCoordinateFromUser("Za =");
int userCoordinateX2 = getCoordinateFromUser("Xb =");
int userCoordinateY2 = getCoordinateFromUser("Yb =");
int userCoordinateZ2 = getCoordinateFromUser("Zb =");
double range = findRangeBetweenTwoPoints(userCoordinateX1, userCoordinateY1, userCoordinateZ1, userCoordinateX2, userCoordinateY2, userCoordinateZ2);

Console.WriteLine($"A ({userCoordinateX1},{userCoordinateY1},{userCoordinateZ1}); B ({userCoordinateX2},{userCoordinateY2},{userCoordinateZ2}) -> {range}");