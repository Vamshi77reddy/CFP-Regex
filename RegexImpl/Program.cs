using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace RegexImpl
{
    internal class Program
    {
         public void MatchWord()
         {
             string inputText = "This is a sample text with multiple words starting with m, such as monkey, mango, and mountain.";

             // Define the regular expression pattern to match words starting with 'm'
             string pattern = @"\b[mM]\w+\b";

             // Create a regular expression object
             Regex regex = new Regex(pattern);

             // Find all matches in the input text
             MatchCollection matches = regex.Matches(inputText);

             // Display the matched words
             Console.WriteLine("Words starting with 'm':");
             foreach (Match m in matches)
             {
                 Console.WriteLine(m);
             }
         }
         static void Main(string[] args)
         {
             /* string input = "Hello   World   ";
              string pattern = "\\s+";
              string replacement = " ";

              Regex rgx = new Regex(pattern);
              string result = rgx.Replace(input, replacement);

              Console.WriteLine("Original String: {0}", input);
              Console.WriteLine("Replacement String: {0}", result);
              Console.ReadKey();
             Program program = new Program();
             program.MatchWord();*/

        /*  private static void showMatch(string text, string expr)
          {
              Console.WriteLine("The Expression: " + expr);
              MatchCollection mc = Regex.Matches(text, expr);

              foreach (Match m in mc)
              {
                  Console.WriteLine(m);
              }
          }
          static void Main(string[] args)
          {
              string str = "A Thousand Splendid Suns";

              Console.WriteLine("Matching words that start with 'S': ");
              showMatch(str, @"\bS\S*");
              Console.ReadKey();
          }*/
        /* static string pattern = "^a...e$";

         static void Main()
         {
             // create an instance of Regex class and
             //  pass the regular expression (i.e pattern)
             RegexI rg = new Regex(pattern);

             // IsMatch() returns true if "apple" matches the regular expression 
             if (rg.IsMatch("apple"))
             {
                 Console.WriteLine("String matches the pattern");
             }
             else
             {
                 Console.WriteLine("String doesn't match the pattern");
             }
         }*/
       /* static void Main(string[] args)
        {
            User r1 = new User();
            r1.UserInput();

        }
       */
    }
}