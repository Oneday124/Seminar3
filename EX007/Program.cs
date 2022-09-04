// Пользовательский ввод массива через строку

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");
}

Console.Write("Введите массив: ");
// int[] array = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
string[] strings = Console.ReadLine()?.Split(' '); //Разделение массива через пробелы
int[] array = new int[strings.Length]; //Создание массива с длинной количества элементов в строке
for(int i = 0; i < strings.Length; i++)
    array[i] = int.Parse(strings[i]);  // Преобразование строки в число по элементно
Console.Write("Ваш массив: ");
PrintArray(array);
