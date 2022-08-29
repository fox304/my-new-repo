// Возведите число А в натуральную степень В используя цикл
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В ");
int b = Convert.ToInt32(Console.ReadLine());
int Degree (int a1,int b1)
{
    int result = 1;
    for (int i = 0; i < b1; i++)
    {
        result *= a1;
    }
    return result;
}
Console.WriteLine($"Число {a} в степени {b} будет равно {Degree(a,b)}");