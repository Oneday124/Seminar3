// Возведите число А в натуральную степень В используя цикл

int Degree(int A, int B)
{
    int sum = 1;
    int degree = 0;
    if(B <= 0)
        return -1;
    else
        for(int i = 0; i < B; i++)
        { 
            degree = sum * A;
            sum = degree;
        }
    return degree;
}

Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");

int degree = Degree(A, B);
Console.WriteLine();

if(B > 0)
    Console.WriteLine($"Число {A} в степени {B} = {degree}");
else
{
    Console.WriteLine($"Степень {B} не является натуральной");
}
