// Создать массив из 8 элементов и вывети их на экран. Решение без методов

Console.WriteLine("Введите длинну массива: ");
int lenght = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[] array = new int[lenght];
int i = 0;
while(i <= lenght - 1)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($" {array[i]}");
    i++;
}
