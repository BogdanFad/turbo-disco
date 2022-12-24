// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,51);
}
return array;
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] array = new int[5];
array = FillArray(array);
PrintArray(array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine("-> "+ sum);