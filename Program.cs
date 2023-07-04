// Тема 20 урок 1

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

int Sum(int x, int y)
{
    return x + y;
}
Console.WriteLine("сумма = " + Sum(a, b));

// Тема 20 урок 2
Random random = new Random();
int[] mas = new int[10];
for (int i = 0; i < mas.Length; i++)
{
    mas[i]=random.Next(21);
    Console.Write(mas[i]+" ");

}

double Znach(int[] array)
{
    double znach = 0;
    for (int i = 0; i < array.Length; i++)
    {
        znach += array[i];
    }
    znach/=array.Length;
    return znach;
}
Console.WriteLine($"среднее значение элементов = {Znach(mas):f2}");