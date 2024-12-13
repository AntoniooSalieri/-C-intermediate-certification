// Задача 1
// Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 
// 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию: 
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

class Program
{
    /// <summary>
    /// methods displays numbers from 1 to N, with each number repeated the corresponding number of times (using recursion)
    /// </summary>
    /// <param name="finish">up to this number the sequence will be executed</param>
    /// <param name="current">the minimum value in the sequence, default is 1.</param>
    static public void PrintRepeatedSequence(int finish, int current = 1)
    {
        if (current <= finish)
        {
            for (int i = 0; i < current; i++)
            {
                if (current != finish || i != current - 1) Console.Write($"{current}, ");
                else Console.Write($"{current} ");

            }
            PrintRepeatedSequence(finish, current + 1);
        }
    }

    static void Main()
    {
        PrintRepeatedSequence(12);
    }
}