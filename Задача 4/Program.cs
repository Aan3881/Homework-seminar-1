// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
int max1 = a;
int max2 = b;
int max3 = c;
if (a > max2) max2 = a;
if (b > max3) max3 = b;
if (c > max1) max1 = c;
{
    Console.Write("Найдено максимальное число ");
}
Console.WriteLine(max1);

