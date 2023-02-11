//Дз 3
/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 > нет;  12821 -> да; 23432 -> да    */
/*
Console.WriteLine ("Введите 5-ти значное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + " Палиндром");
    }

    else
    {
        Console.WriteLine(number + " Не палиндром");
    }
}
else
{
    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
}
*/
/* Напишите программу, которая принимает на вход координаты двух точек и находит
 расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53 */
/*
int x1 = ReadInt("Введите х для точки 1: ");
int y1 = ReadInt("Введите y для точки 1: ");
int z1 = ReadInt("Введите z для точки 1: ");
int x2 = ReadInt("Введите х для точки 2: ");
int y2 = ReadInt("Введите y для точки 2: ");
int z2 = ReadInt("Введите z для точки 2: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125  */

int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}














/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/
/*
int GetQuadrant(int x, int y) 
{
int quadNum = 0;
if(x > 0 && y >0) 
quadNum = 1; 
else if(x < 0 && y > 0) quadNum = 2;
else if(x < 0 && y < 0) quadNum = 3;
else if(x > 0 && y < 0) quadNum = 4;

return quadNum;
}
Console.Write("Inpur a first coordinate: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpur a second coordinate: ");
int yA = Convert.ToInt32(Console.ReadLine());

int result = GetQuadrant(xA, yA);

if(result ==0)
{
    Console.WriteLine("Your point is on axes");
}
else 
{
    Console.WriteLine($"Your point is on {result} quadrant");
}
*/
//Получить число N на входе и вывести квадраты чисел от 1 до N.
/*
void PrintSq(int N)
{
    int i = 1;
    while(i<=N)
    {
        Console.Write(i*i + " ");
        i++;
    }
}
Console.WriteLine("input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintSq(N); 
*/
//Напишите прог, котор принимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве.
/*
double Length(double x1, double y1, double x2, double y2)
{
    double L1 = x2-x1;
    double L2 = y2 -y1;
    double result = Math.Sqrt(Math.Pow(L1,2) + Math.Pow(L2,2));
    return result;
}

Console.Write("Введите координату X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длина отрезка: "+ Math.Round((x1,x2,y2),2));
*/