// Найти сумму чисел от 1 до А
int Sum(int A, int sum)
{
    for(int i = 0; i <= A; i ++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(Sum(A, 0));