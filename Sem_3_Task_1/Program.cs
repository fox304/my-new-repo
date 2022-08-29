// Найти кубы чисел от 1 до N
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Задайте кол-во элементов массива ");
int count = int.Parse(Console.ReadLine());
void Cube(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Куб  числа {i} равен {i*i*i} \n");
    }
}
Cube (count);