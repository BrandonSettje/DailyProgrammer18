using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer18
{
    class Program
    {
        public static string phoneNumberPhrase = string.Empty;
        static void Main(string[] args)
        {
          
          
           
            bool infiniteEntries = true;
            while (infiniteEntries ==  true)
            {
                Console.WriteLine(dialerSwitcher());
            }
            Console.ReadKey();
        }

        public static string dialerSwitcher()
        {
            Console.WriteLine();
            Console.Write("Please enter a phone phrase: ");
            Console.WriteLine();
            phoneNumberPhrase = Console.ReadLine();
            //Invalidate it if its not a real phone number
            if (phoneNumberPhrase.Length < 15 && phoneNumberPhrase.Length > 10  && !phoneNumberPhrase.Contains(" "))
            {
                //A tableless string converter, changes to uppercase before evaluating
                string actualNumber = phoneNumberPhrase.ToUpper().Replace("A", "2").Replace("B", "2")
                .Replace("C", "2").Replace("D", "3").Replace("E", "3").Replace("F", "3")
                .Replace("G", "4").Replace("H", "4").Replace("I", "4").Replace("J", "5")
                .Replace("K", "5").Replace("L", "5").Replace("M", "6").Replace("N", "6")
                .Replace("O", "6").Replace("P", "7").Replace("Q", "7").Replace("R", "7")
                .Replace("S", "7").Replace("T", "8").Replace("U", "8").Replace("V", "8")
                .Replace("W", "9").Replace("X", "9").Replace("Y", "9").Replace("Z", "9").Replace("-", "-");
                if (actualNumber.Contains("-"))
                {
                    return actualNumber;
                }
                else
                {
                    return "The actual number is: " + actualNumber.Insert(1, "-").Insert(5, "-").Insert(9, "-");
                }
            }
            return @"Thats not a real number! You've 
been shammed!";
        }
    }
}
