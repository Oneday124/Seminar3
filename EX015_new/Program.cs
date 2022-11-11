// Написать программу которая будет выводить простые число от 1 до N
int[] FillArray(int n)
{
    int[] array = new int[n];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + 1;
        array[i] = sum;
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); 
    }    
}
void Cur (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            if(array[i] % array[j] == 0 && array[j] != 1 && array[i] != array[j])
            {
            }
            else
            {
                Console.WriteLine($"{array[i]} ");
            }
        }
    }
}

Console.Write("Введите чило: ");
int n = int.Parse(Console.ReadLine() ??"0");
int[] array = FillArray(n);

PrintArray(array);
Console.WriteLine();
Cur(array);





// Console.WriteLine($"{n}");
