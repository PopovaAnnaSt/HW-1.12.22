// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int y=a%2;

if(y == 0)
{
    Console.WriteLine($"Число {a} четное");
}
else
{
    Console.WriteLine($"Число {a} нечетное");
}