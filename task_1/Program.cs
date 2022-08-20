// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_1<num_2)
{
    Console.WriteLine("num_2+" - большее число, а "+num_1+" - меньшее.");
}
else
{
    Console.WriteLine(num_1+" - большее число, а "+num_2+" - меньшее.");
}