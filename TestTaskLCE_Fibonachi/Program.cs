using System;

class Fibonacci
{
    /// <summary>
    /// Метод ля подсчета числа фибоначи
    /// </summary>
    /// <param name="n"> </param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static int CalculateFibonacci(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("n должно быть положительным числом.", nameof(n));
        }
        if (n == 1 || n == 2)
        {
            return 1;
        }

        int prev = 1;    // Предыдущее число
        int current = 1; // Текущее число

        // Вычисление n-го числа Фибоначчи, начиная с третьего числа
        for (int i = 3; i <= n; i++)
        {
            int temp = current;   // Сохраняем текущее число
            current = prev + current; // Вычисляем следующее число как сумму предыдущего и текущего
            prev = temp;          // Обновляем предыдущее число для следующей итерации
        }

        return current;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n)) //Проверка на корректность ввода n
        {
            Console.Write("Поввторите ввод n: ");

        }
        if (n <= 0)
        {
            Console.WriteLine("Было введено число меньше или равное 0");
            return;
        }
        int result = CalculateFibonacci(n);
        Console.WriteLine($"n-ое число Фибоначчи: {result}");
    }
}
