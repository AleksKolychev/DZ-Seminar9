/* Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N. */

int sum(int a, int b)
{
    if (b == a)
        return a;
    return sum(a, b - 1) + b;
}
Console.Clear();
Console.Write("Введите 1-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(m, n));