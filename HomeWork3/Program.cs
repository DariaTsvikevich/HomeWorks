//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Pal (string number)
{
    if (number[0] == number[4] && number[1] == number[3])
        Console.WriteLine($"Your number: {number} is a palindrome.");
    else 
        Console.WriteLine($"Your number: {number} is not a palindrome.");
}
Console.Write("Input number: ");
string number = Console.ReadLine();
Pal(number);
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance (double x1 , double x2, double y1, double y2, double z1, double z2)
{
    double gip = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
    gip = Math.Sqrt(gip);
    return gip;
}
Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double dist = Distance(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"The distance between two dots is {dist}.");
*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube (int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.Write(Math.Pow(i,3) + " ");
        i++;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
*/