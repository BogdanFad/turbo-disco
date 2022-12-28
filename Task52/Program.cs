// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void FillArray(int[, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int number = new Random().Next(0,10);
            array[i, j] = number;
        }
    }
}
void PrintArray(int[, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}
int [, ] array = new int[3,4];
FillArray(array);
PrintArray(array);
for (int i = 0; i < array.GetLength(1); i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        arithmeticMean += array[j, i];
    }
    Console.WriteLine($"Среднее арифметическое элементов столбца {i + 1} = {Math.Round(arithmeticMean / array.GetLength(0),2)}");
}