//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*int Expon (int numberA, int numberB)
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Exponentiation of number {a} in degree {b} is {Expon(a,b)}.");
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int Sum (int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.Write("Input number : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers in number {a} is {Sum(a)}.");
*/