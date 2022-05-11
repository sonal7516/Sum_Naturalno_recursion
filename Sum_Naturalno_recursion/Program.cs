using System;

namespace Sum_Naturalno_recursion
{
    class Program
    {
        static int Sum_NaturalNo(int n)
        {
            if (n<=1)
            
                return n;
                return n + Sum_NaturalNo(n - 1);
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the limit:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Sum of first {0} natural numbers:",n);
            Console.WriteLine(Sum_NaturalNo(n));
        }
    }
}
