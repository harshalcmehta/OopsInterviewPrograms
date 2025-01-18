namespace OopsInterviewPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    string code;
                    Console.WriteLine("Please enter the program core you want to run from the below list");

                    #region List of programs

                    List<string> programs = new List<string>();
                    //programs.Add("Code : 0 , Name : All");
                    programs.Add("Code: 1 , Name: Fibonacci Normal and Reversed with limit");
                    programs.Add("Code: 2 , Name: Check Pallindrome with reversed string");
                    programs.Add("Code: 3 , Name: Check Pallindrome with Multi Variable for loop");
                    programs.Add("Code: 4 , Name: Reverse string with inbuilt function");
                    programs.Add("Code: 5 , Name: Reverse string with for loop and without inbuilt function ");
                    programs.Add("Code: 6 , Name: Reverse string with while loop and without inbuilt function");
                    programs.Add("Code: 7 , Name: Reverse the order of words in a given string");
                    #endregion

                    Console.WriteLine(string.Join("\n", programs));
                    code = Console.ReadLine();
                    var selectedprogram = programs.Where(x => x.Contains("Code: " + code)).FirstOrDefault();
                    Console.WriteLine("\n ------------------------------------------------------");
                    Console.WriteLine("Executing program : {0}", selectedprogram);

                    #region Program execution
                    switch (code)
                    {
                        case "1":

                            Fibonacci.generateFibonacciSeries();
                            break;

                        case "2":
                            Pallindrome.checkPallindromeWithReversedString();
                            break;

                        case "3":
                            Pallindrome.checkPallindromeMultiVariableForLoop();
                            break;

                        case "4":
                            StringPrograms.ReverseStringInbuiltFunction();
                            break;

                        case "5":
                            StringPrograms.ReverseStringForLoop();
                            break;

                        case "6":
                            StringPrograms.ReverseStringWhileLoop();
                            break;

                        case "7":
                            StringPrograms.ReverseOrderOfWordsInString();
                            break;

                        default:
                            Console.WriteLine("Invalid code. Please enter a valid code.");
                            break;
                    }
                    #endregion

                    Console.Write("Do you want to enter another program? (yes/no): ");
                    string response = Console.ReadLine().ToLower(); if (response != "yes")
                    {
                        break; // Exit the outer loop if the user does not want to rerun }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}