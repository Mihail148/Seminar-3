// Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

SquareTable(number);

void SquareTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i} | {Math.Pow(i, 2)}");
    }
}
