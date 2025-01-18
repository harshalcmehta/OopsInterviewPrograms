using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsInterviewPrograms
{
    public class StringPrograms
    {
        public static void ReverseStringInbuiltFunction()
        {
            try
            {
                string str;
                Console.WriteLine("Please enter a string to reverse");
                str = Console.ReadLine();
                char[] c = str.ToCharArray();
                Array.Reverse(c);
                Console.WriteLine("Reversed string : {0} ", new string(c));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure in ReverseStringInbuiltFunction {0}", ex);
            }
        }

        public static void ReverseStringForLoop()
        {
            try
            {
                string str, revstr = string.Empty;
                Console.WriteLine("Please enter string to reverse");
                str = Console.ReadLine();

                for (int s = str.Length - 1; s >= 0; s--)
                {
                    revstr += str[s].ToString();
                }
                Console.WriteLine("Reveresed string from for loop : {0}", revstr);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure in ReverseStringForLoop {}", ex);
            }
        }

        public static void ReverseStringWhileLoop()
        {
            try
            {
                string str, revstr = string.Empty;
                Console.WriteLine("Please enter a string to reverse");
                str = Console.ReadLine();
                int strlength = str.Length - 1;
                while (strlength >= 0)
                {
                    revstr += str[strlength].ToString();
                    strlength--;
                }
                Console.WriteLine("Reversed string by while loop : {0}", revstr);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure in ReverseStringWhileLoop {0}", ex);
            }
        }

        public static void ReverseOrderOfWordsInString()
        {
            try
            {
                string str = string.Empty;
                int i;
                StringBuilder sb = new StringBuilder();
                Console.WriteLine("Please enter a string to reverse the order of words");
                str = Console.ReadLine();

                int start = str.Length - 1;
                int end = str.Length - 1;

                while (start > 0)
                {
                    if (str[start] == ' ')
                    {
                        i = start + 1;
                        while (i <= end)
                        {
                            sb.Append(str[i]);
                            i++;
                        }
                        sb.Append(' ');
                        end = start - 1;
                    }
                    start--;
                }

                //This is required for the First word of the sentence because there won't be space
                //to identify which could have been captured above while loop
                for (i = 0; i <= end; i++)
                {
                    sb.Append(str[i]);
                }

                Console.WriteLine("Reversed order or words : {0}", sb);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure in ReverseOrderOfWordsInString {0}", ex);
            }
        }
    }
}
