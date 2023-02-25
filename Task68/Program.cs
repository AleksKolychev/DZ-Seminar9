/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. */

int akker(int a, int b)
{
    if (a == 0)
        return (b + 1);
    else if (a > 0 && b == 0)
        return akker(a - 1,1);
    else
        return akker(a - 1, akker(a, b - 1));
}
    
Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {akker(m, n)}");