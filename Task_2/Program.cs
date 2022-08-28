// Найти колличество нечётных и чётных элементов
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Hello, World!");
int [] array = new int[10];
void Fillar ()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
}
void Printar ()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
}
void Count (int [] massive)
{
    int even=0,odd=0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i]%2==0) even++;
        else odd++;
    }
    Console.Write($"Кол-во нечётных элементов в массиве {odd} \n");
    Console.Write($"Кол-во чётных элементов в массиве {even} \n\n");
}
Fillar();
Console.WriteLine();
Printar();
Console.WriteLine();
Count(array);
