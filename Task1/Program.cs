// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()!);
int result = numA;
for (int i = 1; i < numB; i++)
{
result = result * numA;  
}
Console.WriteLine($"Число {numA} в степени {numB} равно {result} ");