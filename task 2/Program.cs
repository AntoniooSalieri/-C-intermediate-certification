// Задача 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

class Program
{
    /// <summary>
    /// Ackermann Function
    /// </summary>
    /// <param name="m">first number, >= 0</param>
    /// <param name="n">second number, >= 0</param>
    /// <returns>final answer, outputs -1 if the input values ​​are incorrect</returns>
    static public int AckermannFunction(int m, int n)
    {
        if (m == 0) 
        { 
            return n + 1; 
        }
        else 
        { 
            if (m > 0 && n == 0) 
            { 
                return AckermannFunction(m - 1, 1); 
            }
            else 
            { 
                if (m > 0 && m > 0){
                    return AckermannFunction(m - 1, AckermannFunction(m, n - 1)); 
                } 
            }
        }
        return -1;
    }

    static void Main()
    {
        Console.WriteLine(AckermannFunction(3, 2));
    }

}