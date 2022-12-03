// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int a = 1;

while (a<=n)
{
    int y=a%2;
    if(y == 0)
    {
        Console.Write($"{a} ");
    }
    a++;
}