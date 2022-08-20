// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число до которого будем считать четные числа: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 1)
{
    Console.WriteLine("Вы ввели '1' или меньшее число.");
}
int count = 2;
while (N >= count)
{
    Console.Write(count+", ");
    count=count+2;
}
Console.WriteLine();