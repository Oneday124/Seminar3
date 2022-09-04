// Пользовательский ввод массива
void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");
}


Console.WriteLine("Введите длинну массива: ");
int lenght = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[lenght];

for(int i = 0; i < array.Length;i++)
{
    Console.Write($"Enter {i+1} element of array: ");
    array[i] = int.Parse(Console.ReadLine() ?? "0");
}

Console.Write("Your array: ");
PrintArray(array);