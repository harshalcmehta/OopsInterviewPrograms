using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsInterviewPrograms
{
    public class Fibonacci
    {
        public static void generateFibonacciSeries()
        {
            try
            {
                int limit, num1 = 0, num2 = 1, num3 = 0;
                Console.WriteLine("Please enter a number for Fibonacci series limit");
                limit = Convert.ToInt32(Console.ReadLine());
                List<int> list = new List<int>();
                list.Add(num1);
                list.Add(num2);
                //Console.Write("{0}, {1},", num1, num2);
                for (int i = 2; i < limit; i++)
                {
                    num3 = num1 + num2;
                    if (num3 >= limit)
                    {
                        break;
                    }
                    list.Add(num3);
                    //Console.Write(" {0},", num3);
                    num1 = num2;
                    num2 = num3;
                }
                Console.WriteLine(" Fibonacci Series upto limit {0} : {1},", limit, string.Join(",", list));
                list.Reverse();
                Console.WriteLine(" Reverse Fibonacci Series upto limit {0} : {1},", limit, string.Join(",", list));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failire Reported in Fibonacci : " + ex.Message);
            }
        }
    }
}
