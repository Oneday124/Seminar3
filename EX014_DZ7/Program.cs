// Задать массив из 12 элементов, зполненных числами от 0 до 9. Найти сумму положительных/отрицательных элементов массивов

void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
}
int lenght = 12;
int[] array = new int[lenght];
int sum = 0;
int sum2 = 0;

for(int i = 0; i < lenght; i++)
    array[i] = new Random().Next(0, 10);

PrintArray(array);
Console.WriteLine();
for(int i = 0; i < array.Length; i++)
    if(array[i] >= 0)
        sum = sum + array[i];
    else
        sum2 = sum2 + array[i];

Console.WriteLine($"Сумма положительных элементов массива = {sum}");
Console.WriteLine($"Сумма отрицательных элементов массива = {sum2}");