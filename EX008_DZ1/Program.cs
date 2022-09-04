// Найти кубы чисел от 1 до N

void Kub(int N)
{
    for(int i = 1; i <= N; i++)
    {
        int kub = i*i*i;
        Console.WriteLine(kub);
    }
}

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

Kub(N);
