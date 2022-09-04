// Написать программу вычисления произведения чисел от 1 до N

int Multiplication(int N, int mult)
{
    for(int i = 1; i <= N; i++)
        mult = mult * i; 
return mult;
}
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int mult = Multiplication(N, 1);
if(N <= 0)
    Console.WriteLine($"Введенное число {N} не допустимо, введите число больше 0");
else
    Console.WriteLine($"Произведение чисел от 1 до {N} = {mult}");
