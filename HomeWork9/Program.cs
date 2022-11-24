//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(double n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n - 1);
}
ShowNumbers(10);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int m, int n)
{
    if (m == n) return n;
    return n + SumNumbers(m, n - 1);
}
Console.WriteLine($"Sum of elements near {5} and {10} is {SumNumbers(5, 10)}.");
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
            return Akerman(m - 1, 1);
        else
        {
            return Akerman(m - 1, Akerman(m, n - 1));
        }
    }
}
Console.WriteLine(Akerman(2, 3));
*/
