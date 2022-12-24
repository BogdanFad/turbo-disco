// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] FillArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    double number = new Random().Next(1,100) + new Random().NextDouble();
    array[i] = Math.Round(number,2);
}
return array;
}
void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
double[] array = new double[5];
array = FillArray(array);
PrintArray(array);
double max = array[0];
double min = array[0];
double difference = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
difference = max - min;
Console.WriteLine("\nРазница между "+ max + " максимальным элементом и " + min + " минимальным элементом массива = " + (Math.Round(difference,2)));