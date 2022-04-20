using System;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            System.Console.Write("Bir sayı giriniz : ");
            n = int.Parse(System.Console.ReadLine());
 
            if (Prime.IsPrime(n))
                System.Console.WriteLine("Sayı asaldır");
            else
                System.Console.WriteLine("Sayı asal değildir");
        }
    }
    class Prime
    {
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
 
    }
}
