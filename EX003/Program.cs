// Определить количество цифр в числе

int Resuilt(int num)
{
    int i = 0;
    while (num > 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Количество цифр в числе {num} = " + Resuilt(num));