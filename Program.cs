// Сушинський Ігор
// Лабораторна робота № 1.2
// Цикли.
// Варіант 3

namespace LAB1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            double S = 0;
            double expression = 1 / i + Math.Sqrt(1 + Math.Pow(Math.Sin(i), 2));

            // 1-й спосіб: цикл while
            while (i <= N)
            {
                S += expression;
                i++;
            }
            Console.WriteLine($"1) S = {S}");

            // 2-й спосіб: цикл do-while
            i = 1;
            S = 0;
            do
            {
                S += expression;
                i++;
            } while (i <= N);
            Console.WriteLine($"2) S = {S}");

            // 3-й спосіб: цикл for з інкрементом
            S = 0;
            for (i = 1; i <= N; i++)
            {
                S += expression;
            }
            Console.WriteLine($"3) S = {S}");

            // 4-й спосіб: цикл for з декрементом
            S = 0;
            for (i = N; i >= 1; i--)
            {
                S += expression;
            }
            Console.WriteLine($"4) S = {S}");
        }
    }
}