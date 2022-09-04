// Посчитать сумму цифр в числе

int Sum(int num, int sum)
{
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
return sum;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int sum = Sum(num, 0);

Console.WriteLine($"Сумма цифр в числе {num} = {sum}");