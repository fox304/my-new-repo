// Задать массив из 8 элементов, заполненный нулями и еденицами и вывести их на экран
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Задаём массив из 8 элементов с нулями и единицами");
int [] array =new int[8];
void ZeroAndOne(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write($"{array[i]} ");

    }
}
ZeroAndOne(array);