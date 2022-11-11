// Написать программу которая будет выводить простые число от 1 до N

Console.Write("ВВедите число N: ");
int n = int.Parse(Console.ReadLine() ??"0");

for(int current = 1; current <= n; current++)
{
    int j = 1;
    for(int i = 1; i <= current; i++)
    {
        if(current % i == 0 && i != 1 && i != current)
        {
            Console.Write($"j = {j} ");
            j++;
        }
    }
    Console.WriteLine();
}




