// Показать кубы чисел, заканчивающихся на четную цифру
int Cub(int num)
{
    int cub = 0;
    if(num % 10 % 2 == 0)
    {
        cub = num * num * num;
        return cub;
    }
    else return -1;
}
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int cub = Cub(N);
if(cub == -1) Console.WriteLine($"Число {N} заканчивается на не четную цифру");
else 
    Console.WriteLine($"Куб числа {N} = {cub}");