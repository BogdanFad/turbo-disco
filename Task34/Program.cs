// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int [] array = new int [4];
for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(100,1000);
    array[i] = randomNumber;
    Console.Write(array [i] + " ");
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i] % 2 == 0) sum += 1;
}
Console.WriteLine("-> " + sum);