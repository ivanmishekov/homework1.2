/*
Задача 2: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число > ");
long first = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите второе число > ");
long second = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите третье число > ");
long third = Convert.ToInt64(Console.ReadLine());

if (first > second & first > third)
{
    Console.WriteLine($"Максимальное из этих чисел {first}");
}
else if (second > first & second > third)
{
    Console.WriteLine($"Максимальное из этих чисел {second}");
}
else if (third > first & third > second)
{
    Console.WriteLine($"Максимальное из этих чисел - {third}");
}
else
{
    Console.WriteLine("Error!(Ошибка!)");
}