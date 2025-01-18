using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsInterviewPrograms
{
    public class Pallindrome
    {
        public static void checkPallindromeWithReversedString()
        {
            try
            {
                string str, revstr = string.Empty;
                Console.WriteLine("Please enter a string to check whether it is a Pallindrome");
                str = Console.ReadLine();

                //Reverse string without inbuilt function
                for (int s = str.Length - 1; s >= 0; s--)
                {
                    revstr += str[s].ToString();
                }

                //Reverse string with inbuilt Reverse function
                //char[] c = str.ToCharArray();
                //Array.Reverse(c);
                //revstr = new string(c); //string.Join("", c);


                Console.WriteLine("String entered {0}", str);
                Console.WriteLine("Reveresed string {0}", revstr);

                if (str.ToUpper() == revstr.ToUpper())
                {
                    Console.WriteLine("String {0} is a pallindrome", str);
                }
                else
                {
                    Console.WriteLine("String {0} is not a pallindrome", str);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failire Reported in checkPallindrome : " + ex.Message);
            }
        }
        public static void checkPallindromeMultiVariableForLoop()
        {
            try
            {
                string str;
                Console.WriteLine("Please enter a string to check whether it is a Pallindrome");
                str = Console.ReadLine();
                bool flag = false;
                Console.WriteLine("String entered {0}", str);
                for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
                {
                    if (str[i].ToString().ToUpper() != str[j].ToString().ToUpper())
                    {
                        flag = false;
                        break;
                    }
                    else
                        flag = true;
                }
                if (flag)
                {
                    Console.WriteLine("String {0} is a pallindrome", str);
                }
                else
                    Console.WriteLine("String {0} is not a pallindrome", str);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failire Reported in checkPallindromeMultiVariableForLoop : " + ex.Message);
            }
        }
    }
}
