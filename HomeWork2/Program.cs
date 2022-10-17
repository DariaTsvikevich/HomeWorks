//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber (int number)
{
    int des = number / 10;
    number = des % 10;
    return number;
}

int num = new Random().Next(100,1000);
int result = CutNumber (num);
Console.WriteLine($"Second number of {num} is {result}.");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int CutNumber (int number)
{
    if (number > 9999 || number < 100000)
    {
       number = ((number / 100) % 10);
    }
    else
    {
        Console.WriteLine("Third number doesn't exist");
    }
     return number;   
}
    
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = CutNumber (num);
Console.WriteLine($"Third number of number {num} is {res}");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool WeekEnd (int day)
{
    if (day > 5)
    {
        return true;
    }
    else 
    {
        return false;
    }
}
Console.WriteLine("Input day: ");
int first = Convert.ToInt32(Console.ReadLine());

bool res = WeekEnd (first);
Console.WriteLine ($"The day {first} is a WeekEnd: {res}.");

