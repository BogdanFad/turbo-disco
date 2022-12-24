// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите числа через пробел: ");
string inputText = Console.ReadLine();
string[] stringArray = inputText.Split(' ');
int[] array = new int[stringArray.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(stringArray[i]);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine(" -> " + count);