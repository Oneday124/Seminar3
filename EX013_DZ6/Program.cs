// Создать массив из 8 элементов, заполненных 0 и 1, вывести их на экран
void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");
}

// Console.WriteLine("Введите длинну массива: ");
// int lenght = int.Parse(Console.ReadLine() ?? "0");

int lenght = 8;

int[] array = new int[lenght];
for(int i = 0; i < lenght; i++)
    array[i] = new Random().Next(0, 2);

PrintArray(array);
