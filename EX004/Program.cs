// Создать массив из 8 элементов и вывети их на экран

void Array(int[] collection)
{
    int lenght = collection.Length;
    int i = 0;
    while(i < lenght)
    {
        collection[i] = new Random().Next(0, 10);
        i++;
    }
}

void PrintArray(int[] array)
{                                   // Тело метода PrintArray
    int count = array.Length; //Определение длинны массива
    int position = 0; //position - это индекс для этого метода
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;
    }
}

Console.WriteLine("Введите длинну массива: ");
int lenght = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[] array = new int[lenght];

Array(array);

PrintArray(array);
