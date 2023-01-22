/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

int GetNumber(string message){
    int resultNumber = 0;
    while(true){
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out resultNumber)) break;
        else Console.WriteLine("Вы ввели не коректное число");
    }
    return resultNumber;
}

double GetCoordinates(int x1,int y1,int z1, int x2, int y2, int z2){
    double r = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return r;
}
int x1 = GetNumber("Введите координату x точки A ");
int y1 = GetNumber("Введите координату y точки A ");
int z1 = GetNumber("Введите координату z точки A ");
int x2 = GetNumber("Введите координату x точки B ");
int y2 = GetNumber("Введите координату y точки B ");
int z2 = GetNumber("Введите координату z точки B ");

double result=GetCoordinates(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Расстояние между точка A и B = {result}");

