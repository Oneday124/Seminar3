// Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 0;

while(i <= N)
{
    int result = i * i;
    Console.WriteLine($"{i} * {i} = {result}");
    i++;
}

