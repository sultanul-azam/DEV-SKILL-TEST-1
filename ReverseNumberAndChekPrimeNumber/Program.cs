using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberAndChekPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, rem, i, m= 0, flag = 0;         
            Console.Write("Enter your number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n/ 10;
            }           
            m = reverse / 2;
            for (i = 2; i <= m; i++)
            {
                if (reverse % i == 0)
                {
                    Console.Write("Reversed Number: " + reverse + " (Not Prime)");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Reversed Number: " + reverse + " (Prime)");        
            
            Console.ReadLine();
        }
    }
}
